using System;


namespace FlowerShop
{
  public  class Program
    {
      public  static void Main(string[] args)
        {
            double countMagnol = double.Parse(Console.ReadLine());
            double countZumbul = double.Parse(Console.ReadLine());
            double countRoses = double.Parse(Console.ReadLine());
            double countCactus = double.Parse(Console.ReadLine());
            double priceOfPresent = double.Parse(Console.ReadLine());

            double magnolii = 3.25;
            double roses = 3.5;
            double zumbuli = 4;
            double cactusi = 8;
            double sum = countMagnol * magnolii + countZumbul * zumbuli + countRoses * roses+ countCactus * cactusi;
            double tax = sum * 0.05;
            double price = sum - tax;
            if (priceOfPresent > price)
            {
                double diff = priceOfPresent - price;
                Console.WriteLine("She will have to borrow {0} leva.",Math.Ceiling(diff));
            }
            else
            {
                double diff = price -priceOfPresent ;
                Console.WriteLine("She is left with {0} leva.", Math.Truncate(diff));
            }


        }
    }
}
