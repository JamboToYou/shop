using SampleService.models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace SampleService
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде, SVC-файле и файле конфигурации.
    // ПРИМЕЧАНИЕ. Чтобы запустить клиент проверки WCF для тестирования службы, выберите элементы Service1.svc или Service1.svc.cs в обозревателе решений и начните отладку.
    public class Shop : IShop
    {
        public Shop()
        {
            ConnectToDb();
        }

        private static int countOfCalls = 0;
        SqlConnection conn;
        SqlCommand comm;

        void ConnectToDb()
        {
            string connectString = "Data Source=.\\SQLEXPRESS;Initial Catalog=shopdb;" +
                                   "Integrated Security=true;"; 
           // string connectString = "Server=(localdb)\\shopdb;Integrated Security=true;";

            conn = new SqlConnection(connectString);
            comm = conn.CreateCommand();
        }

        public List<Client> GetAllClients()
        {
            Thread.Sleep(5000);

            //OperationContext.Current.GetCallbackChannel<IService1Callback>().Counter(++countOfCalls);

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
                        Name = reader[1].ToString(),
                        Surname = reader[2].ToString()
                    };
                    clientList.Add(c);
                }
                //OperationContext.Current.GetCallbackChannel<IService1Callback>().ResultClients(clientList);
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
            return clientList;
        }

        public List<Order> GetOrders(Client c)
        {
            Thread.Sleep(5000);

            // OperationContext.Current.GetCallbackChannel<IService1Callback>().Counter(++countOfCalls);
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
                        idClient = Convert.ToInt32(reader[3]),
                        itemName = reader[1].ToString(),
                        itemPrice = Convert.ToInt32(reader[2])
                    };
                    orderList.Add(o);
                }
                // OperationContext.Current.GetCallbackChannel<IService1Callback>().ResultOrders(orderList);
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
            return orderList;
        }
    }
}
