using System;

namespace T1
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var grade = double.Parse(Console.ReadLine());
            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent!");
            }
          
        }
    }
}
