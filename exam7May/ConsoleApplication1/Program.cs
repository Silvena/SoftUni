using System;

namespace task1
{
  public  class Program
    {
        public static void Main(string[] args)
        {
            var wiskey = double.Parse(Console.ReadLine());
            var quantityBeer = double.Parse(Console.ReadLine());
            var quantityWine = double.Parse(Console.ReadLine());
            var quantityRakia = double.Parse(Console.ReadLine());
            var quantityWiskey = double.Parse(Console.ReadLine());

            var priceRakia = wiskey / 2;
            var priceWine = priceRakia - (  0.40 *priceRakia);
            var priceBeer = priceRakia - ( 0.80 * priceRakia );
            var sumRakia = quantityRakia * priceRakia;
            var sumWine = quantityWine * priceWine;
            var sumBeer = quantityBeer * priceBeer;
            var sumWiskey = quantityWiskey * wiskey;
            var sumAll = sumBeer + sumRakia + sumWine + sumWiskey;
           
            Console.WriteLine($"{sumAll:f2}");
        }
    }
}
