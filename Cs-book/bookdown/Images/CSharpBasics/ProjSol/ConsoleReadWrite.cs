// This program demonstrates declaring and initializing variables
// and constants; assignment statement, arithmetic expression,
// and writing to and reading from console
using System;
namespace CSFund1.Chap3.ConsoleReadWriteApp
{
    class ConsoleReadWrite
    {
        public const double PI = 3.1415;
        public const string stdGreeting = "Hi, there!";
        public int age = 0;
        public static void Main()
        {
            Console.WriteLine ("The Value of PI is: {0}", PI);
            Console.WriteLine ("{0} How Old are You?", stdGreeting);
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine ("This Year You Are {0} Years Old!", age);
            age = age + 1;
            Console.WriteLine ("Next Year You Will be {0} Years Old!", age);
        }
    }
}