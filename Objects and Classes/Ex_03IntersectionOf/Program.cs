using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03IntersectionOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle1 = ReadCircle(Console.ReadLine());
            Circle circle2 = ReadCircle(Console.ReadLine());
            int X = circle1.Center.X - circle2.Center.X;
            int Y = circle1.Center.Y - circle2.Center.Y;
            double distanceBetween = Math.Sqrt(X * X + Y * Y);
            if (distanceBetween > circle1.Radius + circle2.Radius)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("Yes");
            }


        }
        static Circle ReadCircle(string input)
        {
            int[] tokens = input.Split(' ').Select(int.Parse).ToArray();
            return new Circle { Center = new Point { X = tokens[0], Y = tokens[1] }, Radius = tokens[2] };
        }
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
        class Circle
        {
            public Point Center { get; set; }
            public int Radius { get; set; }
        }
    }
}
