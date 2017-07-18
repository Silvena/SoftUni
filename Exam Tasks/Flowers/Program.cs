using System;

namespace Flowers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var hrizantema = byte.Parse(Console.ReadLine());
            var rose = byte.Parse(Console.ReadLine());
            var tulip = byte.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string day = Console.ReadLine().ToLower();

            double sumOfFlowers = 0;
            double bouquet = hrizantema + rose + tulip; // when amoun is more than 7 each
           
            if (season == "spring" || season == "summer")
            {
                sumOfFlowers = hrizantema * 2.00 + rose * 4.10 + tulip * 2.50;
                if (day == "y")
                {
                    sumOfFlowers *= 1.15;
                } 

                if (tulip > 7 && season == "spring")
                {
                    sumOfFlowers *= 0.95;
                }
                if (bouquet > 20)
                {
                    sumOfFlowers *= 0.80;
                }
            }
            if (season == "autumn" || season == "winter")
            {
                sumOfFlowers = hrizantema * 3.75 + rose * 4.50 + tulip * 4.15;
                if(day == "y")
                {
                    sumOfFlowers *= 1.15;
                }
                if (rose >= 10 && season == "winter")
                {
                    sumOfFlowers *= 0.90;
                }
                if (bouquet > 20)
                {
                    sumOfFlowers *= 0.80;
                }
            }
            Console.WriteLine("{0:f2}", sumOfFlowers + 2);
        }
    }
}
