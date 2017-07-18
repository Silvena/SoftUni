using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ObjClassFiles_04PunctuationFinder

{
    class Program
    {
        static void Main(string[] args)
        {
           string[] allFiles = File.ReadAllLines(@"sample_text.txt");
            List<char> punctuation = new List<char>();
            char[] PunctToTake = new char[] {'.',',','!','?',':'};
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
            Console.WriteLine(string.Join(", ",punctuation));
        }
    }
}
