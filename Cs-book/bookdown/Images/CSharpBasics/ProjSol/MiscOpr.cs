// Demonstrates increment/decrement, shift, and conditional operators
using System;
namespace CSFund1.Chap3.MiscOprApp
{
	public class MiscOpr
	{
		public static void Main()
		{
			int x = 10, y = 5;
			Console.WriteLine("x = {0}", x);
			// increment and decrement operators
			x++;
			++x;
			x--;
			--x;
			Console.WriteLine("x = {0}", x);
			y = ++x * 2;
			Console.WriteLine("x = {0}  y = {1}", x, y);
			y = x++ * 2;
			Console.WriteLine("x = {0}  y = {1}", x, y);
			// shift operators
			x = x << 4;
			x = x >> 2;
			Console.WriteLine("x = {0}", x);
			// conditional operator
			y = x < 10 ? x * 2 : x * 3;
			Console.WriteLine("x = {0}  y = {1}", x, y);
		}
	}
}