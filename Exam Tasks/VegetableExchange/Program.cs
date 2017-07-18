using System;


namespace VegetableExchange
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var VegPr = double.Parse(Console.ReadLine());
            var FruitPr = double.Parse(Console.ReadLine());
            var SumOfKgVeg = int.Parse(Console.ReadLine());
            var SumOfKgFruit = int.Parse(Console.ReadLine());
              var eur = 1.94;
            var vegCost = (VegPr * SumOfKgVeg);
              var fruitCost = (FruitPr * SumOfKgFruit);
                Console.WriteLine((vegCost + fruitCost)/ eur);
            
        }
    }
}
