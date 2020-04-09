using System.Collections.Generic;
using System.ServiceModel;

namespace WCFtoDB
{
    [ServiceContract(CallbackContract = typeof(IService1Callback), SessionMode = SessionMode.Required)]
    public interface IService1
    {
        [OperationContract(IsOneWay = true)]
        void GetAllClients();

        [OperationContract(IsOneWay = true)]
        void GetOrders(Client c);
    }

    public interface IService1Callback
    {
        // Since we have not set IsOnway=true, the operation is Request/Reply operation
        [OperationContract(IsOneWay = true)]
        void Counter(int countCalls);

        [OperationContract(IsOneWay = true)]
        void ResultClients(List<Client> resultClientList);

        [OperationContract(IsOneWay = true)]
        void ResultOrders(List<Order> resultOrderList);
    }    
}
