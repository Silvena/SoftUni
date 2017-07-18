using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLab_07CounNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            num.Sort();
            var pos = 0;
            while (pos < num.Count)
            {
                int nums = num[pos];
                var count = 1;
                while (pos + count < num.Count && num[pos + count] == nums)
                
                    count++;
                    pos = pos + count;
                Console.WriteLine($"{nums} -> {count}");
                
            }
        }
    }
}
