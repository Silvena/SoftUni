using System;

namespace T11Cinema
{
    public class Program
    {
      public  static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine().ToLower();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
           double result = 0;

            if (typeProjection == "premiere")
            {
                result = r * c * 12.00;
            }
            else if (typeProjection == "normal")
            {
                result = r * c * 7.50;
            }
            else if (typeProjection == "discount")
            {
                result = r * c * 5.00;
            }
            Console.WriteLine("{0:f2}", result);
            Console.WriteLine("leva");
        }
    }
}
