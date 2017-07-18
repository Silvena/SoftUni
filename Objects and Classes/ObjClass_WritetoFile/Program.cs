using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace ObjClass_WritetoFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllText(@"D:\SoftUni\Objects and Classes\ObjClass_WritetoFile\bin\Debug\sample_text.txt")
                           .Split(new char[] { '.', ',', '!', '?', ':', },
                           StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(string.Join("", words));

            //var text = File.ReadAllText(@"D:\SoftUni\Objects and Classes\ObjClass_WritetoFile\bin\Debug\sample_text.txt");
            //var chars = text.Where(c => ".,!?:".IndexOf(c) == -1).ToArray();
            //File.WriteAllText(@"D:\SoftUni\Objects and Classes\ObjClass_WritetoFile\bin\Debug\output.txt", string.Join("",chars));

        }
    }
}
