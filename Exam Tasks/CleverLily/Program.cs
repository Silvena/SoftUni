using System;

namespace CleverLily
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            var washerPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            var moneyForBirthDay = 10;
            var allMoney = 0;
            var toy = 0;
      
            var selltoy = 0;
            var lilybrother = years / 2;

            for (int i = 0; i <= years; i++)
            {
            if (i % 2 == 0)
            {
               moneyForBirthDay = i * 5 ;
                    allMoney = allMoney + moneyForBirthDay;
            }
                else
                {
                    selltoy++;
                    toy = selltoy * toyPrice;

                }
         }
            double total = Math.Abs(allMoney + toy - lilybrother);

            if (total >= washerPrice)
            {
                Console.WriteLine("Yes! {0:f2}", total - washerPrice);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", washerPrice-total);
            }
        }
    }
}
