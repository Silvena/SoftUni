using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionatiesLab_04_Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine();
            List<int> realNumber = num.Split(' ')
                .Select(int.Parse)
                .ToList();
           realNumber = realNumber.OrderByDescending(number => number ).Take(3).ToList();
            Console.WriteLine(string.Join(" ",realNumber));
        }
    }
}
