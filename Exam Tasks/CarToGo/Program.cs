using System;


namespace CarToGo
{
   public class Program
    {
       public static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string seasson = Console.ReadLine().ToLower();
            double priceJeep = 0;
            double priceCabrio = 0;
            var classCar = "";
            var typeCar = "";
            if (budget <= 100)
            {  
                 classCar = "Economy class";
                Console.WriteLine($"{classCar}");
                if (seasson == "summer")
                {
                    typeCar = "Cabrio";
                    priceCabrio = budget * 0.35;
                    Console.WriteLine($"{typeCar} - {priceCabrio:f2}");
                }
                if (seasson == "winter")
                {
                    typeCar = "Jeep";
                    priceJeep = budget * 0.65;
                    Console.WriteLine($"{typeCar} - {priceJeep:f2}");
                }
            }
            else if (budget <=500)
            {
                 classCar = "Compact class";
                Console.WriteLine($"{classCar}");
                if (seasson == "summer")
                {
                    priceCabrio = budget * 0.45;
                    typeCar = "Cabrio";
                    Console.WriteLine($"{typeCar} - {priceCabrio:f2}");
                }
                if (seasson == "winter")
                {
                    priceJeep = budget * 0.80;
                    typeCar = "Jeep";
                    Console.WriteLine($"{typeCar} - {priceJeep:f2}");
                }
            }
            else if(budget > 500)
            {
                classCar = "Luxury class";
                Console.WriteLine($"{classCar}");
                if (seasson == "winter" || seasson == "summer")
                {
                    typeCar = "Jeep";
                    priceJeep = budget * 0.90;
                    Console.WriteLine($"{typeCar} - {priceJeep:f2}");
                }
            }
         
        }
    }
}
