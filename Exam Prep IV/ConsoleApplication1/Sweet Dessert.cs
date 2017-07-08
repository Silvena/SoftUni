using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var cash = decimal.Parse(Console.ReadLine());
            var numOfGuest = decimal.Parse(Console.ReadLine());
            var priceOfBanan = decimal.Parse(Console.ReadLine());
            var priceOfEggs = decimal.Parse(Console.ReadLine());
            var priceOfBerries = decimal.Parse(Console.ReadLine());
            var oneSetBanPortion = 2;
            var oneSetEggPortion = 4;
            decimal berriesPortion = 0.20M;
            var sets = Math.Ceiling(numOfGuest / 6);
            var neededProduct = sets * (oneSetBanPortion * priceOfBanan) + sets * (oneSetEggPortion * priceOfEggs) + sets * (berriesPortion * priceOfBerries);

            if (neededProduct <= cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededProduct:F2}lv.");
            }

            if (neededProduct > cash)
            {
                var diff = neededProduct - cash;

                Console.WriteLine($"Ivancho will have to withdraw money - he will need {diff:F2}lv more.");
            }
        }
    }
}
