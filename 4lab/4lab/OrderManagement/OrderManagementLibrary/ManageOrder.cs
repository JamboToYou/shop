using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace OrderManagementLibrary
{
    public class ManageOrder
    {
        public static int AddOrder(int CustomerID)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=db;Integrated Security=True;Pooling=False;");
            string sql = "INSERT INTO [Order](CustomerID) Values(" + CustomerID.ToString() + ")";
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.CommandType = CommandType.Text;
            conn.Open();
            comm.ExecuteNonQuery();

            sql = "Select Max(orderid) from [Order]";
            comm = new SqlCommand(sql, conn);
            int OrderID = (int) comm.ExecuteScalar();

            conn.Close();

            return OrderID;
        }

        public static void AddOrderDetails(int OrderID, int ProductID, int Amount)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=db;Integrated Security=True;Pooling=False;");
            string sql = String.Format("INSERT INTO [OrderDetails](OrderID, ProductID, Amount) Values({0},{1},{2})",OrderID,ProductID,Amount);
            SqlCommand comm = new SqlCommand(sql, conn);
            comm.CommandType = CommandType.Text;
            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();

            
        }
    }
}
