using System;

namespace m_2SignIntegerNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            printSign(n);
        }
        static void printSign(int n)
        {
           if (n > 0 )
            { 
                Console.WriteLine($"The number {n} is positive.");
            }
            else if (n < 0 )
            {
                Console.WriteLine($"The number {n} is negaive.");
            }
            else
            {
               Console.WriteLine($"The number {n} is zero.");
            }
        }
        
    }
}
