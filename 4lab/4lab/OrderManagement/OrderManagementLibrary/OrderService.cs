using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Transactions;
namespace OrderManagementLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrderService" in both code and config file together.
    [
        ServiceBehavior(
                            TransactionIsolationLevel = System.Transactions.IsolationLevel.Serializable,
                            TransactionTimeout = "00:00:30",
                            InstanceContextMode =InstanceContextMode.PerSession,
                            TransactionAutoCompleteOnSessionClose =true
                            
                       )
    ]
    public class OrderService : IOrderService
    {
        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public int AddOrder(int CustomerID)
        {
           return ManageOrder.AddOrder(CustomerID);
            
        }

        [OperationBehavior(TransactionScopeRequired = true, TransactionAutoComplete = true)]
        public void AddOrderDetails(int OrderID, int ProductID, int Amount)
        {
            ManageOrder.AddOrderDetails(OrderID, ProductID, Amount);
        }
    }
}
