using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMore_03SearchNum
{
    class Program
    {
        static void Main(string[] args)
        {

          
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            var commands = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();


            numbers = numbers
                 .Take(commands[0])
                 .Skip(commands[1])
                 .ToList();

            if (numbers.Contains(commands[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
                   
            
        }
    }
}
