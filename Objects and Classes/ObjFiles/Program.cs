using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Threading.Tasks;

namespace ObjFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allFiles = File.ReadAllLines(@"TextFile1.txt");
            List<char> punctuation = new List<char>();
            char[] PunctToTake = new char[] { '.', ',', '!', '?', ':' };
            foreach (var line in allFiles)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (PunctToTake.Contains(line[i]))
                    {
                        punctuation.Add(line[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", punctuation));
        }
    }
    
}
