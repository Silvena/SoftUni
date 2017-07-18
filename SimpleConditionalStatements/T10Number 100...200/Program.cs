using System;

namespace T10Number_100._._._200
{
   public class Program
    {
       public static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            
            if(number < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if(number >= 100 && number <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (number > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
