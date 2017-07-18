using System;

namespace methodMore_11GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var geometry = Console.ReadLine();

            double result = 0;

            switch (geometry)
            {
                case "triangle":
                    var side = double.Parse(Console.ReadLine());
                    var height = double.Parse(Console.ReadLine());
                    result = TriangleArea(side, height);
                    break;
                case "square":
                    var squareSide = double.Parse(Console.ReadLine());
                    result = SquareArea(squareSide);
                    break;
                case "rectangle":
                    var rectangleWidth = double.Parse(Console.ReadLine());
                    var rectangleHeight = double.Parse(Console.ReadLine());
                    result = RectangleArea(rectangleWidth, rectangleHeight);
                    break;
                case "circle":
                    var radius = double.Parse(Console.ReadLine());
                    result = CircleRadius(radius);
                    break;
            }
            Console.WriteLine($"{result:f2}");
        }
        public static double TriangleArea(double side ,double height)
        {
            return (side * height)/2;
        }
        public static double SquareArea( double squareSide)
        {
            return squareSide * squareSide;

        }
        public static double RectangleArea( double rectangleWidth,double rectangleHeight)
        {
            return rectangleWidth * rectangleHeight;
        }
        public static double CircleRadius(double radius)
        {
           return Math.PI * radius *radius;
        }

    }
}
