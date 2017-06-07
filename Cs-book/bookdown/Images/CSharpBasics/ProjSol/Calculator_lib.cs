// Calculator_dll.cs program 
// For compilation as a library
using System;
namespace CalculatorNS
{
	public class Calculator  
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
		public int Mod (int n1, int n2)
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
}