using System;

namespace Battles
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int player1 = int.Parse(Console.ReadLine());
            int player2 = int.Parse(Console.ReadLine());
            int numBattls = int.Parse(Console.ReadLine());
            int fights = 0;
            for (int i = 1; i <= player1; i++)
            {
                for (int a = 1; a <= player2; a++)
                {
                    if (fights >= numBattls)
                    {
                        break;
                    }
                    Console.Write($"({i} <-> {a}) ");
                    fights++;
                    
                }
            }
        }
    }
}
