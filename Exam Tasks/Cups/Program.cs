using System;


namespace Cups
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            int countCups = int.Parse(Console.ReadLine());
            int countWorkers = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());
            double priceCup = 4.2;
            double workingHours= countWorkers * workingDays *8;
            double madeCups = Math.Truncate(workingHours / 5);
            double diff = (madeCups * priceCup) - (countCups * priceCup);
            if(diff >= 0)
            {
             
                Console.WriteLine($"{diff:0.00} extra money");
            }
            else
            {
              
                Console.WriteLine($"Losses: {Math.Abs(diff):0.00}");
            }
        }
    }
}
