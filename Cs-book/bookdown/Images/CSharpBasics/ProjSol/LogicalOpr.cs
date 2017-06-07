// This progrm demonstrates boolean and bitwise logical operators
using System;
namespace CSFund1.Chap3.LogicalOprApp 
{
	public class LogicalOpr
	{
		public static void Main()
		{
			int x = 5, y = 10;

			Console.WriteLine("x = {0}  y = {1}", x, y);
			// Logical-AND, Logical-OR, Logical-XOR, Logical-Negation
			Console.WriteLine("x < 10 & y > 10 = {0}", x < 10 & y > 10);
			Console.WriteLine("x < 10 | y > 10 = {0}", x < 10 | y > 10);
			Console.WriteLine("x < 10 ^ y > 10 = {0}", x < 10 ^ y > 10);
			Console.WriteLine("!(x < 10) = {0}", !(x < 10));
			// Bitwise-AND, Bitwise-OR, Bitwise-XOR, Bitwise-Negation
			Console.WriteLine("x & y = {0}", x & y);
			Console.WriteLine("x | y = {0}", x | y);
			Console.WriteLine("x ^ y = {0}", x ^ y);
			Console.WriteLine("~x = {0}", ~x);
			// Short-circuit Logical-AND and Logical-OR
			Console.WriteLine("x > 5 && y < 10 = {0}", x > 5 && y < 10);
			Console.WriteLine("x < 10 || y > 10 = {0}", x < 10 || y > 10);
		}
	}
}