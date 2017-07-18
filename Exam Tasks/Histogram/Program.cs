using System;

namespace Histogram
{
   public class Program
    {
    public    static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
               double p1 = 0;
                double p2 = 0;
                double p3 = 0;
                double p4 = 0;
                double p5 = 0;
            for (int i = 0; i < n; i++)
            { 

                var num = int.Parse(Console.ReadLine());

                if (num < 200) p1++;
                else if (num >= 200 && num < 400) p2++;
                else if (num >= 400 & num < 600) p3++;
                else if (num >= 600 & num < 800) p4++;
                else  p5++;
       }     
            double p1Percent = (p1 ) * 100 /n;
            double p2Percent = (p2 ) * 100 / n;
            double p3Percent = (p3 ) * 100 / n;
            double p4Percent = (p4) * 100 / n;
            double p5Percent = (p5 ) * 100 / n;

            Console.WriteLine("{0:f2}%", p1Percent);
            Console.WriteLine("{0:f2}%", p2Percent);
            Console.WriteLine("{0:f2}%", p3Percent);
            Console.WriteLine("{0:f2}%", p4Percent);
            Console.WriteLine("{0:f2}%", p5Percent);
        }
        

    }
}
