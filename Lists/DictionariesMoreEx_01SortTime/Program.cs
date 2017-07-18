using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesMoreEx_01SortTime
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = Console.ReadLine()
                .Split(' ');

            var orederTime = time.OrderBy(x => x);
            Console.WriteLine(string.Join(", ",orederTime));
                
            
        }
    }
}
