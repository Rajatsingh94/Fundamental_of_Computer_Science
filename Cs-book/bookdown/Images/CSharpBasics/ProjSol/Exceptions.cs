// Demonstrates handling of user-defined exceptions
using System; 
namespace CSFund1.Chap3.ExceptionsApp
{
	public class Calculator  
	{ 
		public int Add (int n1, int n2) 
		{ 
			return n1 + n2;
		} 
		public int Div (int n1, int n2)
		{ 
			return n1 / n2;
		} 
	}
	class ExceptionsApp
	{
		public static void Main()
		{
			int num1, num2, result;
			string[] strArray = {"First", "Second", "Third"};
			Calculator myCalc = new Calculator();
			try
			{
				Console.WriteLine("Enter a (int) number");
				num1 = Int32.Parse(Console.ReadLine());
				Console.WriteLine("Enter another (int) number");
				num2 = Int32.Parse(Console.ReadLine());
				Console.WriteLine();
				result = myCalc.Add(num1, num2);
				Console.WriteLine("{0} + {1} is: {2}", num1, num2, result);
				result = myCalc.Div(num1, num2);
				Console.WriteLine("{0} / {1} is: {2}", num1, num2, result);
				Console.WriteLine("strArray[0] is: {0}", strArray[0]);
				Console.WriteLine("strArray[3] is: {0}", strArray[3]);
				Console.ReadLine();
			}
			catch(System.OverflowException e)
			{
				Console.WriteLine("Type: {0}", e.GetType());
				Console.WriteLine("Source: {0}", e.Source);
				Console.WriteLine("Message: {0}", e.Message);
			}
			catch(System.DivideByZeroException e)
			{
				Console.WriteLine("Type: {0}", e.GetType());
				Console.WriteLine("Source: {0}", e.Source);
				Console.WriteLine("Message: {0}", e.Message);
			}
			catch(Exception e)
			{
				Console.WriteLine("Type: {0}", e.GetType());
				Console.WriteLine("Source: {0}", e.Source);
				Console.WriteLine("Message: {0}", e.Message);
			}
			finally
			{
				Console.WriteLine("Control always comes here");
			}
		}
	}
}