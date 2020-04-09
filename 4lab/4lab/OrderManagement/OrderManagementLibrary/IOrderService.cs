using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Transactions;
namespace OrderManagementLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrderService" in both code and config file together.
    [ServiceContract(SessionMode =SessionMode.Required)]
    public interface IOrderService
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        int AddOrder(int CustomerID);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        void AddOrderDetails(int OrderID,int ProductID, int Amount);
    }
}
