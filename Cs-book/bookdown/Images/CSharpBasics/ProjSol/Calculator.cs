using System; 
namespace CSFund1.Chap3.CalculatorApp
{ 
	class Calculator  
	{ 
		public int Add (int n1, int n2) 
		{ 
			return n1 + n2;
		} 
		public int Sub (int n1, int n2)
		{ 
			return n1 - n2;
		}
		public int Mult (int n1, int n2)
		{ 
			return n1 * n2;
		}
		public int Div (int n1, int n2)
		{ 
			return n1 / n2;
		} 
		public static int Mod (int n1, int n2)
		{ 
			return n1 % n2;
		}
		public double Power (double baseNum, double expoNum) 
		{ 
			return Math.Pow (baseNum, expoNum);
		}
		public int Abs (int n1) 
		{ 
			return Math.Abs(n1);
		} 
	}
	class CalcApp
	{
		public static void Main()
		{
			int num1 = 10;
			int num2 = 2;
			int result;

			// Public static (i.e., class-level) methods can be accessed directly
			Console.WriteLine("{0} % {1} = {2}", num1, num2, Calculator.Mod(num1, num2));
			// Create an instance of the Calculator class using the new operator
			Calculator myCalc = new Calculator();
			// Now access public non-static methods via myCalc object reference
			result = myCalc.Add(num1, num2);
			Console.WriteLine("{0} + {1} = {2}", num1, num2, result);
			Console.WriteLine("{0} + {1} = {2}", num1, num2, myCalc.Add(num1, num2));
			Console.WriteLine("{0} - {1} = {2}", num1, num2, myCalc.Sub(num1, num2));
			Console.WriteLine("{0} * {1} = {2}", num1, num2, myCalc.Mult(num1, num2));
			Console.WriteLine("{0} / {1} = {2}", num1, num2, myCalc.Div(num1, num2));
			Console.WriteLine("{0} to the power {1} = {2}", num1, num2, myCalc.Power((double)num1, (double)num2));
			num1 = -2050;
			Console.WriteLine("Absolute value of {0} is: {1}", num1, myCalc.Abs(num1));
		}
	}
}