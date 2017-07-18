using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries_02LabOddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
           string[] sequenceOfWords = input.Split(' ').ToArray();


            var counts = new Dictionary<string, int>();
            foreach (var item in sequenceOfWords)
            {
                if (counts.ContainsKey(item))
                {
                 counts[item]++;
            
                }
                else
                {
                  counts[item] = 1; 
                }
          
           }
            var result = new List<string>();
            foreach (var pair in counts)
            { 
              if (pair.Value % 2 == 1)result.Add(pair.Key);
                
            }
         Console.WriteLine(string.Join(", ",result));
        }
    }
}
