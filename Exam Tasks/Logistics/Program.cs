using System;

namespace Logistics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int countLoad = int.Parse(Console.ReadLine());
            int[] load = new int[countLoad];

            double microbus = 0;
            double truck = 0;
            double train = 0;
            double sum = 0;

            for (int i = 0; i <= load.Length - 1; i++)
            {
                load[i] = int.Parse(Console.ReadLine());

                if (load[i] <= 3)
                {
                    microbus += load[i];
                }
                if (load[i] >= 4 && load[i] <= 11)
                {
                    truck += load[i];
                }
                if (load[i] >= 12)
                {
                    train += load[i];
                }
                sum += load[i];
            }
            double average = (microbus*200 + truck*175 + train*120)/sum;

                Console.WriteLine($"{average:0.00}");
                Console.WriteLine($"{microbus / sum * 100:0.00}%");
                Console.WriteLine($"{truck / sum * 100:0.00}%");
                Console.WriteLine($"{train / sum * 100:0.00}%");


            
        }
    }
}
