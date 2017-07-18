using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodore_8CenterPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            if (point1IsCloserToCenter(x1,y1,x2,y2))
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
        private static  bool point1IsCloserToCenter(double x1,double y1,double x2,double y2)
        {
            var distance1 = calulateDistance(x1,y1,0 ,0);
            var distance2 = calulateDistance(x2, y2, 0, 0);

            if (distance1 < distance2)
            {
                return true;
            }
            return false;
        }
        private static double calulateDistance(double x1, double y1, double x2, double y2)
        {
            var distance = Math.Sqrt(Math.Pow(x2 - x1, 2)) + Math.Pow(y2 - y1, 2);
            return distance;
        }
    }
}
