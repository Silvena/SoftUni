using System;


namespace sleepingCatTom
{
    public class Program
    {
        public static void Main(string[] args)
        {
            decimal numRestDays = decimal.Parse(Console.ReadLine());
     
            decimal playWorkDaysminutes = (365 - numRestDays) * 63;
            decimal playRestDayminutes = numRestDays * 127;
            decimal realTimeForPlay = playWorkDaysminutes + playRestDayminutes;
          
      if (30000 >= realTimeForPlay)
            {
                decimal days = Math.Floor((30000 - realTimeForPlay) / 60);
                decimal hours = (30000 - realTimeForPlay) % 60;

                Console.WriteLine("Tom sleeps well \n{0:f0} hours and {1} minutes less for play", days, hours);

            }
            else
            {
                decimal days1 = Math.Floor((realTimeForPlay - 30000) / 60);
                decimal hours1 = (realTimeForPlay - 30000) % 60;

                Console.WriteLine("Tom will run away \n{0:f0} hours and {1} minutes more for play", days1, hours1);

            }  
        }
    }
}
