using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_3LastKNumbersSumsSequence
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            var num = new long[n];
            num[0] = 1;

            for (int i = 1; i < n; i++)
            {
                long sum = 0;
                for (int prevu = i - k; prevu <= i - 1; prevu++)
                {
                    if (prevu >= 0)
                    {
                        sum += num[prevu];

                    }
                    num[i] = sum;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(num[i] + " ");
             
            }
            Console.WriteLine();
        }
    }
}

