using System;

namespace DailyEarnings
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var workDaysInMonth = int.Parse(Console.ReadLine());
            double dailyWage = double.Parse(Console.ReadLine());
            double dayCourseUsdToBgn = double.Parse(Console.ReadLine());

            var monthlyWage = workDaysInMonth * dailyWage;
            var yearWage = monthlyWage * 12 + monthlyWage * 2.5;
            var tax = 0.25 * yearWage;
            var yearCleenWaget = (yearWage - tax)*dayCourseUsdToBgn;
            var averageProfitPerDay = yearCleenWaget / 365;
            Console.WriteLine("{0:f2}",averageProfitPerDay);
             
        }
    }
}
