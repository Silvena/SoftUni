using System;


namespace GreaterNumber
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter a two integers:");
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("Greater number: " + num1);
            }
            else
            {
                Console.WriteLine("Greater number: " + num2);
            }

        }
    }
}
