using System;

namespace m_5CalculateTriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = GetTiangleArea( width,  height);
            Console.WriteLine(area);
        }
        static double GetTiangleArea(double width ,double height)
        {
            return width * height /2;
        }
    }
}
