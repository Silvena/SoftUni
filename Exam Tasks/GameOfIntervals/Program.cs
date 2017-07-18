using System;

namespace GameOfIntervals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double ctr1 = 0;
            double ctr2 = 0;
            double ctr3 = 0;
            double ctr4 = 0;
            double ctr5 = 0;
            double sum = 0;
            double result = 0;
            double invalidNum = 0;

            for (int i = 1; i <= n; i++)
            {

                double count = double.Parse(Console.ReadLine());

               
                if (count >= 0 && count < 10)
                {
                    ctr1++;
                    result = count * 0.20;
                    sum += result;
                }
              else  if (count >= 10 && count < 20)
                {
                    ctr2++;
                  result = count * 0.30;
                    sum += result;
                }
               else if (count >= 20 && count < 30)
                {
                    ctr3++;
                    result = count * 0.40;
                    sum += result;
                }
               else if (count >= 30 && count < 40)
                {
                    ctr4++;
                    result = 50;
                    sum += result;
                }
               else if (count >= 40 && count <= 50)
                {
                    ctr5++;
                    result = 100;
                    sum += result;
                }
                else
                {
                    invalidNum++;
                    sum /= 2;
                }
              }  
                Console.WriteLine($"{sum:f2}");
                Console.WriteLine($"From 0 to 9: {ctr1/n *100:f2}%");
                Console.WriteLine($"From 10 to 19: {ctr2 / n * 100:f2}%");
                Console.WriteLine($"From 20 to 29: {ctr3 / n * 100:f2}%");
                Console.WriteLine($"From 30 to 39: {ctr4 / n * 100:f2}%");
                Console.WriteLine($"From 40 to 50: {ctr5 / n * 100:f2}%");
                Console.WriteLine($"Invalid numbers: {invalidNum / n * 100:f2}%");
          
        }
    }
}
