namespace shop_svc
{
	public class CalculatorService : ICalculatorService
	{
		public int Add(int x, int y) => x + y;

		public int Divide(int x, int y) => x / y;

		public int Multiple(int x, int y) => x * y;

		public int Substract(int x, int y) => x - y;
	}
}