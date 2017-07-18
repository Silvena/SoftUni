using System;

namespace TriangleArea
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());

            // S = (a*h) / 2
            double a = Math.Abs(x2 -x3);
            double h = Math.Abs(y1 - y3);
            double TriangleArea = (a * h)/2;
            Console.WriteLine(Math.Abs(TriangleArea));

        }
    }
}
