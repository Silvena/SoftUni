using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lab_04MergeFiles
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine(output);
        }
        public static void MergeFiles(string pathFile1, string path2File, string output)
        {
            File.WriteAllText(output, File.ReadAllText(path2File) + File.ReadAllText(path2File));
        }
    }
}
