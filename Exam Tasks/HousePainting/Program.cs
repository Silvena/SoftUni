using System;

namespace HousePainting
{
   public class Program
    {
       public static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            // Green Paint
            double greenPaint = 3.4;
            double redPaint = 4.3;
            double asideWall =  x * y;
            double windowArea = 1.5 * 1.5;
            double twoSideOfHouse = (2* asideWall)- (2 * windowArea);
            double behindWall = x*x;
            double enter = 1.2 * 2;
            double frontBack = (2 * behindWall) - enter;
            double sumGreenPaint = (frontBack + twoSideOfHouse)/greenPaint;
            // Red Paint
            double twoRectangle = 2*(x*y);
            double twoTriangle = 2 * (x * h / 2);
            double sumRedPaint =(twoRectangle + twoTriangle)/redPaint;

          
            Console.WriteLine("{0:f2}",sumGreenPaint);

              Console.WriteLine("{0:f2}",sumRedPaint);


        }
    }
}
