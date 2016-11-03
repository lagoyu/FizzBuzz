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
            const int fizzFactor = 3;
            const int buzzFactor = 7;

            for (int i = 1; i <= 100; i++)
            {
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
