using System;
using System.Numerics;
namespace methodMore_13Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            PrintFactorialCount(number);
        }
        static void PrintFactorialCount(int number)
        {
            BigInteger factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
           
            Console.WriteLine(factorial);
        }
    }
}
