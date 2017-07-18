using System;

namespace Pateshestvie
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            var season = Console.ReadLine().ToLower();

            decimal holiday = (decimal)0;

            if (season == "summer")
            {
                if (budget <= 100)
                {
                    holiday = (decimal)0.70 * budget;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - {0:f2}",budget - holiday);
                }
                else if (budget <= 1000)
                {
                    holiday = (decimal)0.60 * budget;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - {0:f2}",budget - holiday);
                }
                else if (budget > 1000)
                {
                    holiday = (decimal)0.90 * budget;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - {0:f2}", holiday);
                }

            }
         else   if (season == "winter")
            {
                if (budget <= 100)
                {
                    holiday = (decimal)0.30 * budget;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - {0:f2}",budget - holiday);
                }
                else if (budget <= 1000)
                {
                    holiday = (decimal)0.20 * budget;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - {0:f2}",budget - holiday);
                }
         
            else if(budget > 1000)
            {
                holiday = (decimal)0.90 * budget;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine("Hotel - {0:f2}",holiday);
            }
             }
        }
    }
}
