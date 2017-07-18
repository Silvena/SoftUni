using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx_8MostFrequentNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequance = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse).ToArray();
            int[] consts = new int[65535];
            int maxConunt = 0;
            int frequentNum = 0;
            for (int i = 0; i < sequance.Length; i++)
            {
                consts[sequance[i]]++;
                if (consts[sequance[i]] > maxConunt)
                {
                    maxConunt = consts[sequance[i]];
                    frequentNum = sequance[i];
                }
            }
            Console.WriteLine(frequentNum);
        }
    }
}
