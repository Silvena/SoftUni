using System;

namespace methodMore_7PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var startNum = int.Parse(Console.ReadLine());
            var endNum = int.Parse(Console.ReadLine());
            var isPrime = IsPrimeInRange(startNum , endNum);
            Console.WriteLine(isPrime);
        }
        private static List<int> IsPrimeInRange( int startNum ,int endNum)
        {
            var primes = new List<int>();
            for (int currentNum  = startNum; currentNum  <= endNum; currentNum ++)
            {
                if (IsPrime(currentNum))
                {
                    primes.Add(currentNum);
                }
            }

        }
        private static bool IsPrime(long num)
        {
            if (num == 0 || num == 1)
            {
                return false;
            }
            if (num == 2)
            {
                return true;
            }
            for (int currentNum = 2; currentNum <= Math.Sqrt(num); currentNum++)
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
