using System;

namespace T7SumSeconds
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int seconds = num1 + num2 + num3;

            int mins = seconds / 60;
            seconds = seconds % 60;

            Console.WriteLine("{0}:{1}", mins, seconds.ToString().PadLeft(2,'0'));
        }
    }
}
