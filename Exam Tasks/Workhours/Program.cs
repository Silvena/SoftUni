using System;


namespace Workhours
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int needHours = int.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());
            int workDays = int.Parse(Console.ReadLine());
           
            int workHours= workers *8* workDays ;
            int leftHours = 0;
            int penalties = 0;
            if (workHours >= needHours)
            {
                leftHours = workHours - needHours;
                Console.WriteLine($"{leftHours} hours left");
            }
            else
            {
                leftHours = needHours - workHours;
                 penalties = leftHours * workDays;
                Console.WriteLine($"{leftHours} overtime");
                Console.WriteLine($"Penalties: {penalties}");
            }

        }
    }
}
