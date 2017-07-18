using System;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string catergory = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());
            double transport = 0;
            if (people <=4)
            {
               transport = budget * 0.75;
            }
          else if ( people <= 9)
            {
                transport = budget * 0.60;
            }
          else  if ( people <= 24)
            {
                transport = budget * 0.50;
            }
         else  if (people <= 49)
            {
                transport = budget * 0.40;
            }
           else if (people >= 50)
            {
                transport = budget * 0.25;
            }

            double leftMoney = budget - transport;
            double priceTiket = 0;

            if (catergory == "vip")
            {
                priceTiket = people * 499.99;
                if (priceTiket < leftMoney)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.",leftMoney-priceTiket);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.",priceTiket -leftMoney);
                }
            }
            else
            {
                priceTiket = people * 249.99;
                if (priceTiket < leftMoney)
                {
                    Console.WriteLine("Yes! You have {0:f2} leva left.", leftMoney - priceTiket);
                }
                else
                {
                    Console.WriteLine("Not enough money! You need {0:f2} leva.", priceTiket - leftMoney);
                }
            }
            
        }
    }
}
