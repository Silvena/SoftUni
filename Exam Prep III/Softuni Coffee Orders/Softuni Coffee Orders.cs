using System;
using System.Globalization;

namespace softuniCoffeOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOrders = int.Parse(Console.ReadLine());
            decimal totalExpenses = 0;
            for (int i = 0; i < countOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());

                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);

                decimal countCapsules = decimal.Parse(Console.ReadLine());

                int daysInMonth = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);

                decimal currentPrice = daysInMonth * countCapsules * pricePerCapsule;

                totalExpenses += currentPrice;

                Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");
            }
            Console.WriteLine($"Total: ${totalExpenses:F2}");


        }
    }

}
