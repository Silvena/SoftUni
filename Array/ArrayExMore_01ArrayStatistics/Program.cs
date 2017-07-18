using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExMore_01ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] anArray = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(long.Parse).ToArray();

            var maxValue = anArray.Max();
            var minValue = anArray.Min();
            var sumArr = anArray.Sum();
            var averageArr = anArray.Average();
            Console.WriteLine($"Min = {minValue}");
            Console.WriteLine($"Max = {maxValue}");
            Console.WriteLine($"Sum = {sumArr}");
            Console.WriteLine($"Average = {averageArr}");
        }
    }
}
