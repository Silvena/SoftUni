using System;


namespace TriangleOfDollars
{
   public class Program
    {
       public static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
              //  Console.Write('$');
                for (int col = 0; col < row; col++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}
