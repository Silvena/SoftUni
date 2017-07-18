using System;


namespace InTimeForExam
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minutesExam = int.Parse(Console.ReadLine());
            int hourArrive = int.Parse(Console.ReadLine());
            int minuteArrive = int.Parse(Console.ReadLine());

            int examTime = (hourExam * 60) + minutesExam;
            int arriveTime = (hourArrive * 60) + minuteArrive;

            int range = examTime - arriveTime;
            int difference = Math.Abs(range);
            int hours = difference / 60;
            int minutes = difference % 60;


            if (range <= 30 && range >= 0)
            {
                Console.WriteLine("On time");

                if (range != 0)
                {
                    Console.WriteLine("{0} minutes before the start", difference);
                }
            }
            else if (range > 30)
            {
                Console.WriteLine("Early");
                if (difference < 60)
                {
                    Console.WriteLine("{0:00} minutes before the start", difference);
                }
                else
                {
                    Console.WriteLine("{0}:{1:00} hours before the start", hours, minutes);
                }
            }
            if (range < 0)
            {
                Console.WriteLine("Late");  
                if (difference < 60)
                {
                    Console.WriteLine("{0:00} minutes after the start", difference);
                }
                else 
                {
                    Console.WriteLine("{0}:{1:00} hours after the start", hours, minutes);
                }
            }

        }
    }
}
