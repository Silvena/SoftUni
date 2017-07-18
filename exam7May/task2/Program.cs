using System;

namespace task2
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            var priceTrip = double.Parse(Console.ReadLine());
            var countPuzzel = int.Parse(Console.ReadLine());
            var countTalkDoll = int.Parse(Console.ReadLine());
            var countBers = int.Parse(Console.ReadLine());
            var countMinion = int.Parse(Console.ReadLine());
            var countTrucks = int.Parse(Console.ReadLine());
            var puzzel = 2.60;
            var talkDoll = 3.0;
            var bear = 4.10;
            var minion = 8.20;
            var truck = 2.0;
            var price = countPuzzel * puzzel + countTalkDoll * talkDoll + countBers *bear +countMinion * minion + countTrucks * truck;
            var toys = countPuzzel + countTalkDoll + countBers + countMinion + countTrucks;

            if (toys >= 50)
            {
                price = price - (0.25 * price);
            }
            var forRent = price * 0.1;
            var profit = price - forRent ;

           
            if (profit >= priceTrip)
            {

                Console.WriteLine($"Yes! {profit - priceTrip:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceTrip - profit:f2} lv needed.");
            }
            
        }
    }
}
