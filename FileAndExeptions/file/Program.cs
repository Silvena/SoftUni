using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file
{
    class Program
    {
        static void Main(string[] args)
        {
        
               File.Create("input.txt");
               string[] text = File.ReadAllLines("input.txt");
               File.WriteAllLines("output.txt", text.Where((line, index) => index % 2 == 1));
              //file.Create(input.txt);

          
        }
    }
}
