﻿using System;


namespace T9DayOfWeek
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                case 8:
                    Console.WriteLine("Error");
                    break;
            } 
        }
    }
}
