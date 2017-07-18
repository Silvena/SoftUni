using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileAndEx_01MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var sequance = File.ReadAllLines("inputMostFrNum.txt");

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
