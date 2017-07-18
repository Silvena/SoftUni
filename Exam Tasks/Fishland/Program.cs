using System;


namespace Fishland
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double priceMackerel = double.Parse(Console.ReadLine()); // skumriq
           double priceSprat = double.Parse(Console.ReadLine());  // caca
            double kgBonito = double.Parse(Console.ReadLine()); // palamud
            double kgScad = double.Parse(Console.ReadLine()); //safrid
            double kgMussel = double.Parse(Console.ReadLine()); // midi

            var priceBonito = priceMackerel * 1.60;
            kgBonito *= priceBonito;
            var priceScad = priceSprat * 1.80;
            kgScad *= priceScad; 
            var priceMussel = 7.50;
            kgMussel *= priceMussel;
            var sumAll = kgBonito+ kgScad + kgMussel;
            Console.WriteLine($"{sumAll:f2}");
        }
    }
}
