using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharityMarathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var lenghtOfMaratonInDays = decimal.Parse(Console.ReadLine());
            var numOfRunners = decimal.Parse(Console.ReadLine());
            var averageNumOfLapsEvRunner = decimal.Parse(Console.ReadLine());
            var lengthOfTrack = decimal.Parse(Console.ReadLine());
            var capacyOfTrack = decimal.Parse(Console.ReadLine());
            var donatedMoneryPerKM = decimal.Parse(Console.ReadLine());


            var capacy = Math.Min(numOfRunners, capacyOfTrack * lenghtOfMaratonInDays);
            var totalMeters = capacy * averageNumOfLapsEvRunner * lengthOfTrack;
            var totalKM = totalMeters / 1000;
            var money = totalKM * donatedMoneryPerKM;

            Console.WriteLine($"Money raised: {money:F2}");
        }
    }
}
