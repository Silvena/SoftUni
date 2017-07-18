using System;

namespace Grades
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double sum = 0;
            int topStident = 0;
            int veryGood = 0;
            int good = 0;
            int fail = 0;
            for (int i = 0; i < n; i++)
            {
                double rate = double.Parse(Console.ReadLine());
                sum += rate;
                if (rate < 3.00)
                {
                    fail++;
                }
                else if (rate < 4.00)
                {
                    good++;
                }
                else if (rate < 5.00)
                {
                    veryGood++;
                }
                else
                {
                    topStident++;
                }
            }
            Console.WriteLine($"Top students: {(topStident /(double)n*100).ToString("0.00")}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(veryGood /(double)n*100).ToString("0.00")}%");
            Console.WriteLine($"Between 3.00 and 3.99: {(good /(double)n*100).ToString("0.00")}%");
            Console.WriteLine($"Fail: {(fail /(double)n*100).ToString("0.00")}%");
            double avg = sum / n;
            Console.WriteLine($"Average: {avg.ToString("0.00")}");

        }
    }
}
