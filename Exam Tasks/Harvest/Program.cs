using System;


namespace Harvest
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            double vineyards = double.Parse(Console.ReadLine());
            double grape = double.Parse(Console.ReadLine());
            double needWine = double.Parse(Console.ReadLine());
            double workers = double.Parse(Console.ReadLine());

            var sumVine = (vineyards * grape)*0.40;
            var wine = sumVine/2.5;
         
         if (wine >= needWine)
            {
                var result = Math.Floor(wine - needWine);
                 workers = Math.Ceiling(result / workers);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.\n{1} liters left -> {2} liters per person.", wine , result , workers );
            }
            else
            {
                var result1 = needWine - wine;
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", Math.Floor(result1));

            }
            
        }
    }
}
