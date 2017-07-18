using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExMore_04GrapGo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int searchNum = int.Parse(Console.ReadLine());
            var index = 0;
            bool isFound = false;
            for (int i = array.Length -1 ; i >= 0; i--)
            {
                if (array[i] == searchNum)
                {
                    index = i;
                    isFound = true;
                    break;
                }
            }
            long sum = 0;
            if (isFound)
            {
                for (int i = 0; i < index; i++)
                {
                    sum += array[i];
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("No occurrences were found!");
            }
        }
    }
}
