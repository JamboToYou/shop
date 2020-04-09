using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Transactions;
namespace OrderServiceClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService.OrderServiceClient client = new OrderService.OrderServiceClient();
            using (TransactionScope ts = new TransactionScope())
            {
                try
                {
                    int OrderID = client.AddOrder(3);
                    client.AddOrderDetails(OrderID, 10, 10);
                    ts.Complete();
                    Console.WriteLine("Transaction Complete. Check database for changes");
                    Console.ReadKey();
                }
                catch (Exception ex)
                {
                   
                }
            }

        }
    }
}
