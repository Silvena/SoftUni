using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLab_02AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] list = Console.ReadLine().Split('|').ToArray();
   

            List<int> result = new List<int>();

            for (int i = list.Length-1; i >= 0; i--)
            {
                var numbers = list[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                result.AddRange(numbers);
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
