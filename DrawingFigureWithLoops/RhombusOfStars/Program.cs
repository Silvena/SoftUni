using System;

namespace RhombusOfStars
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));

                for (int c = 0; c < i; c++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            for (int a = n - 1; a > 0; a--)
            {
                Console.Write(new string(' ', n - a));   // sum of interval on row(i) - num of stars (n) 

                for (int c = 0; c < a; c++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }


        }
    }
}
