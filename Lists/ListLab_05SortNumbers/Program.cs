﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListLab_05SortNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<decimal> numbers = Console.ReadLine()
                .Split(' ')
                .Select(decimal.Parse)
                .ToList();

           numbers.Sort();
            Console.WriteLine(string.Join(" <= ",numbers));
        }
    }
}
