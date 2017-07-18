using System;

namespace T12Volleyball
{
   public class Program
    {
        public static void Main(string[] args)
        {
            var typeOfYear = Console.ReadLine().ToLower();      //  leap or normal
            var p = double.Parse(Console.ReadLine()); // num. holiday in year without weekends
            var h = double.Parse(Console.ReadLine()); // num. weekend traveling to home
            var weekInYear = 48.0; 
            double normalWeekend = ((weekInYear - h) * 3.0 / 4);
            double playsWeekend = p * 2.0 / 3.0;
            double result = normalWeekend + playsWeekend + h  ;
            if (typeOfYear == "leap")
            {
                result = result * 1.15; //  1.15 = 15% if year s leap
               
            }
            Console.WriteLine(Math.Truncate(result));
            
        }
    }
}
