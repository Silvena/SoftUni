using System;


namespace Factorial
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var fact = 1;
            do
            {
                fact = fact * n;
                n--;

            } while (n >1);
            Console.WriteLine(fact);
        }
    }
}
