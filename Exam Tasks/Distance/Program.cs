using System;
namespace Distance
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int speedkm = int.Parse(Console.ReadLine());
            int firstTime = int.Parse(Console.ReadLine());
            int secondTime = int.Parse(Console.ReadLine());
            int thirdTime = int.Parse(Console.ReadLine());

            double speed = speedkm;
            var distanseSpeedKm = speed * firstTime /(double)60;
            speed = speed * 1.1;
            double afteradd = speed * secondTime / (double)60;
            speed = speed * 0.95;
            double afterdumb = speed * thirdTime / (double)60;
            double totalDistance = distanseSpeedKm + afteradd + afterdumb ;
           
            Console.WriteLine("{0:f2}",totalDistance);

        }
    }
}
