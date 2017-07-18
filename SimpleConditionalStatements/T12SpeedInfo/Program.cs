using System;


namespace T12SpeedInfo
{
   public class Program
    {
       public static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number <= 10)
            {
                Console.WriteLine("slow");
            }
            else if (number >= 10 && number <= 50)
            {
                Console.WriteLine("average");
            }
            else if (number >= 50 && number <= 150)
            {
                Console.WriteLine("fast");
            }
            else if (number >= 150 && number <= 1000)
            {
                Console.WriteLine("ultra fast");
            }
            else if (number > 1000)
            {
                Console.WriteLine("extremely fast");
            }
        }
    }
}
