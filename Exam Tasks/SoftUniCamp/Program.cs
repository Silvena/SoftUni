using System;

namespace SoftUniCamp
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int sumStudent = 0;
            int car = 0;
            int microbus = 0;
            int smallBus = 0;
            int bigBus = 0;
            int train = 0;


            for (int i = 0; i < groups; i++)
            {
                int people = int.Parse(Console.ReadLine());
                sumStudent += people;
                if (people <= 5)
                {
                    car += people;
                }
               else if (people <= 12)
                {
                    microbus += people;
                }
                else if (people <=25)
                {
                    smallBus += people;
                }
                else if (people <= 40)
                {
                    bigBus += people;
                }
                else
                {
                    train += people;
                }
            }
            double carPercent = (double)car / sumStudent *100;
            double microBusPercent = microbus / (double)sumStudent * 100;
            double smallBusPercent = (double)smallBus / sumStudent * 100;
            double bigBusPercent = (double)bigBus / sumStudent * 100;
            double trainPercent = (double)train / sumStudent * 100;
            Console.WriteLine("{0:f2}%",carPercent);
            Console.WriteLine("{0:f2}%",microBusPercent);
            Console.WriteLine("{0:f2}%",smallBusPercent);
            Console.WriteLine("{0:f2}%",bigBusPercent);
            Console.WriteLine("{0:f2}%",trainPercent);

        }
    }
}
