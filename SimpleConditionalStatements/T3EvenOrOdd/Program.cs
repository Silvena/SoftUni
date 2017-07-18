using System;

namespace T3EvenOrOdd
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            if (num % 2 == 0 )
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}
