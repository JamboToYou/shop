using System.ServiceModel;

namespace shop_svc
{
	[ServiceContract]
	public interface ICalculatorService
	{
		[OperationContract]
		int Add(int x, int y);

		[OperationContract]
		int Substract(int x, int y);

		[OperationContract]
		int Multiple(int x, int y);

		[OperationContract]
		int Divide(int x, int y);
	}
}