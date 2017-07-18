using System;


namespace Diamond
{
   public class Program
    {
       public static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            int firstRow = (n - 1) / 2;


            for (int i = 0; i < (n-1)/2; i++)
            {
                Console.Write(new string('-', firstRow));
                Console.Write("*");
                var middle = n - 2 * firstRow - 2;
                if (middle >=0)
                {
                    Console.Write(new string('-', middle));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-',firstRow));
                firstRow--;
            }
            for (int i = n/2; i < n; i++)
            {
                Console.Write(new string('-', firstRow));
                Console.Write("*");
                var middle = n - 2 * firstRow - 2;
                if (middle >= 0)
                {
                    Console.Write(new string('-', middle));
                    Console.Write("*");
                }
                Console.WriteLine(new string('-', firstRow));
                firstRow++;
            }
        }
    }
}
