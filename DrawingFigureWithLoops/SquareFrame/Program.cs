using System;
namespace SquareFrame
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //print on top :  +---+
            Console.Write("+");
            for (int x = 0; x < n - 2; x++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
            //middle rows
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write("|");
                for (int y = 0; y < n - 2; y++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }

            //bottom rows  +---+
            Console.Write("+");
            for (int z = 0; z < n - 2; z++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");

        }
    }
}
