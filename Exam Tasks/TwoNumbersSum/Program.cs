using System;


namespace TwoNumbersSum
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            int strat = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sumOfNum = int.Parse(Console.ReadLine());

            int counter = 0;
            int numA = 0;
            int numB = 0;
            for (int i = strat; i >= end; i--)
            {
                for (int b = strat; b >= end; b--)
                {
                    counter++;
                    numB = b;
                    if (i + b == sumOfNum) break;
                   }
                numA = i;
                if (numA + numB == sumOfNum) break;
            }
            if (numA + numB == sumOfNum)
            {
                Console.WriteLine($"Combination N:{counter} ({numA} + {numB} = {sumOfNum})");
            }
            else
            {
                Console.WriteLine($"{counter} combinations - neither equals {sumOfNum}");
            }
        }
    }
}
