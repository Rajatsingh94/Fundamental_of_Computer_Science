// Demonstartes various forms of the assignment operator
using System;
namespace CSFund1.Chap3.AssignmentOprApp
{
	public class AssignmentOpr
	{
		public static void Main()
		{
			int x = 10;
			Console.WriteLine("x = {0}", x);

			x += 5;		// x = x + 5
			x -= 10;	// x = x - 10
			x *= 4;		// x = x * 4
			x /= 2;		// x = x / 2
			x %= 3;		// x = x % 3
			Console.WriteLine("x = {0}", x);
			x <<= 4;	// x = x << 4
			x >>= 2;	// x = x >> 2
			Console.WriteLine("x = {0}", x);
			x &= 10;	// x = x & 10
			x |= 10;	// x = x | 10
			x ^= 8;		// x = x ^ 8
			Console.WriteLine("x = {0}", x);
		}
	}
}