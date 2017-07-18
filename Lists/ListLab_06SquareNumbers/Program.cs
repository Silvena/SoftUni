using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLab_06SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            var squares = new List<int>();
            foreach (var num in input)
            {
                if (Math.Sqrt(num) % 1 == 0)
                {
                    squares.Add(num);
                }    
            }
            squares.Sort();
            squares.Reverse();
            Console.WriteLine(string.Join(" ",squares));
        }
    }
}
