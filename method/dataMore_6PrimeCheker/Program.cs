using System;

namespace dataMore_6PrimeCheker
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());

            var isPrime = IsPrime(num);
            Console.WriteLine(isPrime);
        }
        private static bool IsPrime(long num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }
            if (num == 2 )
            {
                return true;
            }
            for (int currentNum = 2; currentNum <= Math.Sqrt(num) ; currentNum++)
            {
                if (num % currentNum == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
