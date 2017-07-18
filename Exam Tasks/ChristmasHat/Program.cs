using System;

namespace ChristmasHat
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int startAndDot = (4 * n - 2) / 2;
            int stars = 4 * n + 1;
            Console.Write(new string('.',startAndDot));
            Console.Write(@"/|\");
            Console.WriteLine(new string('.', startAndDot));

            Console.Write(new string('.', startAndDot));
            Console.Write(@"\|/");
            Console.WriteLine(new string('.', startAndDot));
              for (int row = 0; row < 2* n; row++)
            {
                Console.WriteLine(
                    new string('.',startAndDot - row)+ "*"+
                    new string('-',row)+ "*" +
                    new string('-', row)+ "*" +
                    new string('.', startAndDot - row));      
            }
            Console.WriteLine(new string('*',stars));
            Console.Write("*");
            for (int i = 0; i < 2*n; i++)
            {
                Console.Write(".*");
            }
            Console.WriteLine();
            Console.WriteLine(new string('*', stars));

        }
    }
}
