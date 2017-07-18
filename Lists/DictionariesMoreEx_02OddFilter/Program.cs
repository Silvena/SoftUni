using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesMoreEx_02OddFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            numbers.RemoveAll(x => x % 2 !=0);
            var average = numbers.Average();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    numbers[i]++;

                }
              else  if (numbers[i] <= average)
                {
                    numbers[i]--;

                }
              
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
