using System;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodMore_14FactorialTrZone
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
            int trainglingZone = 0;
            while (factorial % 10 == 0)
            {
                trainglingZone++;
                factorial /= 10;
            }
            Console.WriteLine(trainglingZone);
        }

    }
}
