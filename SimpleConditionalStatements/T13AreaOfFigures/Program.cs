using System;

namespace T13AreaOfFigures
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter Type of Figure");
            var fig = Console.ReadLine();
            double area;

            if (fig == "square")
            {
                double l = double.Parse(Console.ReadLine());
                area = Math.Pow(l,2);
                Console.WriteLine("{0} ",area);
            }
            else if (fig == "rectangle")
            {
                double x = double.Parse(Console.ReadLine());
                double y = double.Parse(Console.ReadLine());
                area = Math.Round(x * y, 2);
                Console.WriteLine("{0} ", area);
            }
            else if (fig == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                area =Math.Round(( Math.PI * r * r),3);
                Console.WriteLine("{0} ", area); 
            }
            else if (fig == "triangle")
            {
                double leng = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = (leng * h) / 2.0;
                Console.WriteLine("{0}", area);
            }


        }
    }
}
