using System;

namespace SumOfTwoNumbers
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int counter = 0;
            int numA = 0;
            int numB = 0;
            for (int i = start; i <= end; i++)
            {
                for (int  a = start ; a <= end; a++)
                {
                    counter++;
                    numA = a;
                    if (i + a == magicNum) break;
                }
                numB = i;
                if (numB + numA == magicNum) break;
            }
            if (numB + numA == magicNum)
            {
                Console.WriteLine($"Combination N: ({numB} + {numA} = {magicNum})");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
