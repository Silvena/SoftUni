using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionariesMoreEx_03ImmuneSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> virusses = new List<string>();
            int initialStreigth = int.Parse(Console.ReadLine());
            string virus = Console.ReadLine();
            int maxHealt = initialStreigth;
            while (virus != "end")
            {
                
                int virussesStrength = CalcilateViruss(virus);
                int virusTime = virussesStrength * virus.Length ;
                if (virus.Contains(virus))
                {
                    virusTime= (int) (virusTime/ 3.0);
                }
                else
                {
                    virusses.Add(virus);
                }
                //  Console.WriteLine(virussesStrength);
                //   Console.WriteLine(virusTime);
                initialStreigth -= virusTime;
                Console.WriteLine($"Virus {virus}: {virussesStrength} => {virusTime} seconds");
               
               
              //  var remainingHealth = virusTime - initialStreigth;
               
                if (initialStreigth <= 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    break;
                }
                else
                {
                     Console.WriteLine($"{virus} defeated in {CalculateTime(virusTime)}.");
                     Console.WriteLine($"Remaining health: {initialStreigth}");
                }
                initialStreigth = Math.Min(maxHealt, (int)(initialStreigth * 1.2));
                virus = Console.ReadLine();
            } 
        }

        private static int CalcilateViruss(string virus)
        {
            int totalStrength = 0;
            for (int i = 0; i < virus.Length; i++)
            {
                totalStrength += virus[i];
            }
            return (int)(totalStrength / 3.0);
        }
        private static string CalculateTime(int time)
        {
            return time / 60 + "m " + time % 60 + "s";
        }
    }
}
