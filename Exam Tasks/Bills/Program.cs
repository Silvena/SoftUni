using System;

namespace Bills
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            double sumOfElectr = 0;
            double water = 20;
            double net = 15;
            double others = 0;
            double average = 0;

            for (int i = 0; i < month; i++)
            {
                double billElecr = double.Parse(Console.ReadLine());
                sumOfElectr = sumOfElectr + billElecr;

            }
            others = (sumOfElectr + (water * month) + (net * month));
            others = others +(others * 0.2);
            average = (sumOfElectr + (water * month) + (net * month) + others);


            Console.WriteLine("Electricity: {0:f2} lv", sumOfElectr);
            Console.WriteLine("Water: {0:f2} lv", water * month);
            Console.WriteLine("Internet: {0:f2} lv", net * month);
            Console.WriteLine("Other: {0:f2} lv",others);
            Console.WriteLine("Average: {0:f2} lv", average / month);
        }
    }
}
