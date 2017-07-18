using System;

namespace Firm
{
   public class Program
    {
       public static void Main(string[] args)
        {
            double needHours = double.Parse(Console.ReadLine());
            double daysForProject = double.Parse(Console.ReadLine());
            double numWorkersExtraHours = double.Parse(Console.ReadLine());


            double workingHours = (0.90 * daysForProject) * 8;
            double workersExtraHours = numWorkersExtraHours * (2 * daysForProject);
            double sumHours = Math.Floor(workingHours + workersExtraHours);


            if (sumHours >= needHours)
            { 
            Console.WriteLine("Yes!{0} hours left.",sumHours - needHours);
            }
            else
            {
             Console.WriteLine("Not enough time!{0} hours needed.",needHours -sumHours);
            }
           
        }
    }
}
