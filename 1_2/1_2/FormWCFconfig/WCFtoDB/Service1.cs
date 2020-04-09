using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace WCFtoDB
{
    public class Service1 : IService1
    {
        public Service1()
        {
            ConnectToDb();
        }

        private static int countOfCalls = 0;
        SqlConnection conn;
        SqlCommand comm;
        
        void ConnectToDb()
        {
            string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=msdb;" +
                                   "Integrated Security=true;";

            conn = new SqlConnection(connectString);
            comm = conn.CreateCommand();
        }

        public void GetAllClients()
        {
            Thread.Sleep(5000);

            OperationContext.Current.GetCallbackChannel<IService1Callback>().Counter(++countOfCalls);

            List<Client> clientList = new List<Client>();

            try
            {
                comm.CommandText = "SELECT * FROM Clients";
                comm.CommandType = CommandType.Text;

                conn.Open();
                
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Client c = new Client()
                    {
                        idClient = Convert.ToInt32(reader[0]),
                        SNP = reader[1].ToString()
                    };
                    clientList.Add(c);
                }
                OperationContext.Current.GetCallbackChannel<IService1Callback>().ResultClients(clientList);
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
               if (conn!=null)
                {
                    conn.Close();
                }
            }
        }

        public void GetOrders(Client c)
        {
            Thread.Sleep(5000);

            OperationContext.Current.GetCallbackChannel<IService1Callback>().Counter(++countOfCalls);
            List<Order> orderList = new List<Order>();

            try
            {
                comm.CommandText = "SELECT * FROM Orders WHERE id_client=@Id";
                comm.Parameters.AddWithValue("Id", c.idClient);
                comm.CommandType = CommandType.Text;

                conn.Open();
                
                SqlDataReader reader = comm.ExecuteReader();
                while (reader.Read())
                {
                    Order o = new Order()
                    {
                        idOrder = Convert.ToInt32(reader[0]),
                        idClient = Convert.ToInt32(reader[1]),
                        description = reader[2].ToString()
                    };
                    orderList.Add(o);
                }
               OperationContext.Current.GetCallbackChannel<IService1Callback>().ResultOrders(orderList);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
     }
}
