using System;

namespace GrapeAndRakia
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            double areaVineyard = double.Parse(Console.ReadLine());
            double kgFromKvm = double.Parse(Console.ReadLine());
            double lost = double.Parse(Console.ReadLine());
            double profitRakia = 0;
            double profitGrape = 0;
            double campQuanutity = 0;
            double totalQuantity = 0;
            campQuanutity = areaVineyard * kgFromKvm;
            totalQuantity = campQuanutity - lost;
            profitRakia = 0.45 * totalQuantity / 7.5 *9.8; //7.5kg grape for 1l rakia
                                                           //9.8 prise of 1l rakia
            profitGrape = 0.55 * totalQuantity * 1.5;
            Console.WriteLine("{0:f2}",profitRakia);
            Console.WriteLine("{0:f2}", profitGrape);
        }
    }
}
