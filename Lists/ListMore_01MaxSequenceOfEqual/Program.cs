using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMore_01MaxSequenceOfEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            /*   List<int> sequance = Console.ReadLine()
                   .Split().Select(int.Parse).ToList();

               int maxStart = 0;
               int maxLen = 1;
               int currentStart = 0;
               int currentLen = 1;
               for (int i = 1; i < sequance.Count; i++)
               {
                   if (sequance[i] == sequance[currentStart])
                   {
                       currentLen++;
                       if (currentLen > maxLen)
                       {
                           maxLen = currentLen;
                           maxStart = currentStart;
                       }
                   }
                   else
                   {
                       currentLen = 1;
                       currentStart = i;
                   }
               }
               for (int i = maxStart; i < maxStart + maxLen; i++)
               {
                   Console.Write($"{sequance[i]} ");
               }
               */

            string[] inputNumber = Console.ReadLine().Split();
            int[] parseNumb = new int[inputNumber.Length];

            for (int i = 0; i < inputNumber.Length; i++)
            {
                parseNumb[i] = int.Parse(inputNumber[i]);
            }
            List<int> longestSequence = new List<int>();
            List<int> currentSequence = new List<int>();

            currentSequence.Add(parseNumb[0]);

            for (int i = 1; i < parseNumb.Length; i++)
            {
                if ( parseNumb[i]== currentSequence[0])
                {
                    currentSequence.Add(parseNumb[i]);
                }
                else
                {
                    if (currentSequence.Count > longestSequence.Count)
                    {
                       
                              longestSequence = new List<int>();
                             for (int j = 0; j < currentSequence.Count; j++)
                             {
                                   longestSequence.Add(currentSequence[j]);
                             }
                         }
                    currentSequence = new List<int>();
                        currentSequence.Add(parseNumb[i]);
                   
                }
               

            }
            Console.WriteLine(string.Join(" ", longestSequence));


        }
    }
}
