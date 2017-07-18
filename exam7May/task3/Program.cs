using System;

namespace task3
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            var seasson = Console.ReadLine().ToLower();
            var groop = Console.ReadLine().ToLower();
            var students = double.Parse(Console.ReadLine());
            var nights = double.Parse(Console.ReadLine());
            var disscount = 0.0;
            var sport =  " ";
            var priceNights = 0.0;
            if (seasson == "winter")
            {
                if (groop == "boys") { priceNights = students *  nights *9.60; sport = "Judo"; }
               else if (groop == "girls") { priceNights = students * nights * 9.60; sport = "Gymnastics"; }
               else if (groop == "mixed") { priceNights = students * nights * 10; sport = "Ski"; }
               
            }
           else if (seasson == "spring")
            {
                if (groop == "boys") { priceNights = students * nights * 7.20; ; sport = "Tennis"; }
                else if (groop == "girls") { priceNights = students * nights * 7.20; sport = "Athletics"; }
                else if (groop == "mixed") { priceNights= students * nights * 9.50; sport = "Cycling"; }
            }
            else if (seasson == "summer")
            {
                if (groop == "boys") { priceNights = students * nights * 15; sport = "Football"; }
                else if (groop == "girls") { priceNights= students * nights * 15; sport = "Volleyball"; }
                else if (groop == "mixed") { priceNights= students * nights * 20; sport = "Swimming"; }
            }   
            
            if (students >= 50)
                {
                    disscount = priceNights / 2;
                }
                else if (students >= 20 && students <= 50)
                {
                    disscount = priceNights * 0.15;
                }
                else if (students >= 10 && students < 20)
                {
                    disscount = priceNights * 0.05;
                }
        
            var lastPrice = priceNights - disscount ;
            Console.WriteLine($"{sport} {lastPrice:f2} lv.");
        }
    }
}
