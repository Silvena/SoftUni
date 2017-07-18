using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_4TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] num = new int[input.Length];
                for (int i = 0; i < input.Length; i++)
                {
                    num[i] = int.Parse(input[i]);
                }
            bool tripleExist = false;
                    for (int i = 0; i < num.Length; i++)
                    {
                        for (int j = i + 1; j < num.Length; j++)
                        {
                            for (int k = 0; k < num.Length; k++)
                            {
                                if (num[i] + num[j] == num[k])
                                {
                                    Console.WriteLine($"{num[i]} + {num[j]} == {num[k]}");
                                    tripleExist = true;
                                    break;
                                }
                            }
                        }
                    }
            if (!tripleExist)
            {
                Console.WriteLine("No");
            }

        }
    }
}
