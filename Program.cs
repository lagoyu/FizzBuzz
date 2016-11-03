using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use constants instead of 'magic numbers'
            const int fizzFactor = 3;
            const int buzzFactor = 5;

            for (int i = 1; i <= 100; i++)
            {
                // % is the remainder operator
                // See https://msdn.microsoft.com/en-us/library/0w4e0fzs.aspx
                // && is logical AND operator
                // See https://www.tutorialspoint.com/csharp/csharp_logical_operators.htm
                if ((i % fizzFactor == 0) && (i % buzzFactor == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % fizzFactor == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % buzzFactor == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    }
}
