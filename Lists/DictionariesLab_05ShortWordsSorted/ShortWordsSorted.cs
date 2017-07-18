using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesLab_05ShortWordsSorted
{
    class ShortWordsSorted
    {
        static void Main(string[] args)
        {
          
            char[] separators = new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' ' };
            string text = Console.ReadLine().ToLower();
            string[] words = text.Split(separators);

            var result = words
            .Where(w => w != "")
            .Where(w => w.Length < 5) //prin all words with less  5 char
            .OrderBy(w => w)
            .Distinct();
     

            Console.WriteLine(string.Join(", ",result));
            
        }
    }
}
