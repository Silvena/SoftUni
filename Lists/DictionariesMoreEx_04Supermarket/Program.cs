using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesMoreEx_04Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<decimal>>();
            var input = Console.ReadLine().Split(' ').ToArray();

            while (input[0] != "stocked")
            {
                var item = input[0].ToString();
                var price = decimal.Parse(input[1]);

                var quantity = decimal.Parse(input[2]);

                if (!dict.ContainsKey(item))
                {
                    dict[item] = new List<decimal>();
                    dict[item].Add(price);
                    dict[item].Add(quantity);
                }

                else
                {
                    dict[item][0] = price;
                    dict[item][1] += quantity;
                }

                input = Console.ReadLine().Split(' ').ToArray();
            }
            var total = 0m;
            foreach (var w in dict)
            {
                total += w.Value[0] * w.Value[1];
                Console.WriteLine($"{w.Key}: ${w.Value[0]:f2} * {w.Value[1]} = ${(w.Value[0] * w.Value[1]):f2}");
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${total:F2}");
        }
    }
}
