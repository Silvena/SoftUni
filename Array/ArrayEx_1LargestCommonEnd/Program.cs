using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx_1LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string[] array2 = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            int lengthArrL = 0;
            int lengthArrR = 0;

            for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
            {
                if (array1[i] == array2[i])
                {
                    lengthArrL++;
                }
                else if (array1[array1.Length - 1  -i] == array2[array2.Length - 1 - i])
                {
                    lengthArrR++;
                }
            }
            if (lengthArrL >= lengthArrR)
            {
                Console.WriteLine(lengthArrL);
            }
            else
            {
                Console.WriteLine(lengthArrR);
            }



           // bool IsEqual = Enumerable.SequenceEqual(array1, array2);
            //Console.WriteLine(IsEqual);
        }

    }
}
