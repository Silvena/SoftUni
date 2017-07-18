using System;

namespace GreatestCommonDivisor
{
  public  class Program
    {
      public  static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (b != 0)
            {
                var oldB = b;
                b = a % b;
                a = oldB;
            }
            Console.WriteLine("GCD = {0} ",a);
        }
    }
    
}
