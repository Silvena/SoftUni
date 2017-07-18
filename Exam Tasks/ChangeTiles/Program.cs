using System;

namespace ChangeTiles
{
   public class Program
    {
      public  static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double wideFloor = double.Parse(Console.ReadLine());
            double lenghtFloor = double.Parse(Console.ReadLine());
            double sideTriangle = double.Parse(Console.ReadLine());
            double hightTriange = double.Parse(Console.ReadLine());
            double priceOfTile = double.Parse(Console.ReadLine());
            double amountMaster = double.Parse(Console.ReadLine());

            var areaOfFloor = wideFloor * lenghtFloor;
            var areaOfTile = sideTriangle * hightTriange / 2;
            var needTile = Math.Ceiling(areaOfFloor / areaOfTile) + 5;
            var total = needTile * priceOfTile + amountMaster;
          
            if (budget >= total)
            {
                Console.WriteLine("{0:0.00} lv left.",budget - total);
            }
          else 
            {
                Console.WriteLine("You'll need {0:f2} lv more.",total-budget);
            }
        }
    }
}
