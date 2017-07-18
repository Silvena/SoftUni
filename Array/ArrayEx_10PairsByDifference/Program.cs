using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx_10PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequanceOfNumbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());

            int counter = 0;
            for (int i = 0; i < sequanceOfNumbers.Length; i++)
            {
                for (int k = i; k < sequanceOfNumbers.Length; k++)
                {
                    var absValue = Math.Abs(sequanceOfNumbers[k] - sequanceOfNumbers[i]);
                    if (absValue == difference && i < k)
                    {
                        counter++;
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
