using System;


namespace Styrofoam
{
 public   class Program
    {
       public static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var areaOfHouse = double.Parse(Console.ReadLine());
            var numWinows = double.Parse(Console.ReadLine());
            var styrofoarm = double.Parse(Console.ReadLine());
            var pricePackStyr = double.Parse(Console.ReadLine());
            double costs = 0;
            double all = 0;
            double totalPackStyr = 0;
            all = (areaOfHouse - numWinows*2.4);
            all = all+(all * 0.1); //10% wastage
          
           totalPackStyr = Math.Ceiling(all / styrofoarm);
            costs = totalPackStyr * pricePackStyr;
            
       if (budget > costs)
            {


                Console.WriteLine("Spent: {0:f2}",costs);
                Console.WriteLine("Left: {0:f2}", budget -costs);
            }
            else
            {

                Console.WriteLine("Need more: {0:f2}",costs - budget);
            }
           
        }
    }
}
