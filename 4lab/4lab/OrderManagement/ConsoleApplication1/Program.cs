using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using OrderManagementLibrary;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(OrderService)))
            {
                // Start listening for messages
                host.Open();

                Console.WriteLine(
                  "The service is running and is listening on:");
                foreach (ServiceEndpoint endpoint in
                 host.Description.Endpoints)
                {
                    Console.WriteLine("{0} ({1})",
                      endpoint.Address.ToString(), endpoint.Binding.Name);
                }
                Console.WriteLine();
                Console.WriteLine("Press any key to stop the service.");
                Console.ReadKey();

                // Close the service
                host.Close();
            }
        }
    }
}
