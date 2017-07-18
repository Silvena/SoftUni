using System;

namespace BikeRace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int countJuniors = int.Parse(Console.ReadLine());
            int countSeniors = int.Parse(Console.ReadLine());
            string trase = Console.ReadLine().ToLower();

            double junior = 0;
            double senior = 0;

            if (trase == "trail")
            {
                junior = countJuniors * 5.50;
                senior = countSeniors * 7;
                double sumTrail = (junior + senior) * 0.05;
                Console.WriteLine($"{(junior+senior)-sumTrail:0.00}");
                
            }
            if (trase == "cross-country")
            {
                junior = countJuniors * 8;
                senior = countSeniors * 9.5;
                double sumCross = (junior + senior)*0.05;
               
                double countSum = countJuniors + countSeniors;

              
                if (countSum >= 50)
                {
                   double disscount = ((junior + senior) - sumCross)*0.25;
                 
                Console.WriteLine($"{((junior + senior) - sumCross)-disscount:0.00}");//113
                }
                else
                {
                Console.WriteLine($"{(junior+senior)-sumCross:0.00}");//453
                }
              
            }
            if (trase == "downhill")
            {
                junior = countJuniors * 12.25;
                senior = countSeniors * 13.75;
                double sumDownhill = (junior + senior) * 0.05;
                Console.WriteLine($"{(junior + senior) - sumDownhill:0.00}");
            }
            if (trase == "road")
            {
                junior = countJuniors * 20;
                senior = countSeniors * 21.50;
                double sumRoad = (junior + senior) * 0.05;
                Console.WriteLine($"{(junior + senior) - sumRoad:0.00}");
            }
            
        }
    }
}
