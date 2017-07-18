using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListMoreSumReversedNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputNumber = Console.ReadLine().Split();

            int sum = 0;

            for (int i = 0; i < inputNumber.Length; i++)
            {
                string currentNum = inputNumber[i];
                string reversedNum = string.Join("",currentNum.Reverse());
                int parsedNUm = int.Parse(reversedNum);
                sum += parsedNUm;
            }
            Console.WriteLine(sum);
        }
    }
}
