using System;


namespace maxCombination
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int maxComb = int.Parse(Console.ReadLine());
            int maxCombination = 0;
            for (int i = start; i <= end; i++)
            {
                for (int a = start; a <= end; a++)
                {
                if (maxComb == maxCombination )
                {
                        break;
                }
                Console.Write($"<{i}-{a}>");
                maxCombination++;
                
              }
                
            }
            Console.WriteLine();
        }
    }
}
