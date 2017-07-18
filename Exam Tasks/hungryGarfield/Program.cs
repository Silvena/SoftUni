using System;


namespace hungryGarfield
{
    public class Program
    {
        public static void Main(string[] args)
        {   
            
            var money = decimal.Parse(Console.ReadLine());
            var dollarRate = decimal.Parse(Console.ReadLine());
            var pizzaPrice = decimal.Parse(Console.ReadLine())/ dollarRate;
            var lasagnaPrice = decimal.Parse(Console.ReadLine())/ dollarRate;
            var sandwichPrice = decimal.Parse(Console.ReadLine())/ dollarRate;
            var pizzaQuantity = uint.Parse(Console.ReadLine());
            var lasagnaQuantity = uint.Parse(Console.ReadLine());
            var sandwichQuantity = uint.Parse(Console.ReadLine());


  var pizzaNeed = pizzaPrice * pizzaQuantity;
            var lasagnaNeed = lasagnaPrice * lasagnaQuantity;
            var sandwichNeed= sandwichPrice * sandwichQuantity;

            var garfNeed = pizzaNeed+ lasagnaNeed +sandwichNeed;

            if (money >= garfNeed)
            {
             
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.",money-garfNeed);
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.",garfNeed-money);
            }

        }
    }
}
