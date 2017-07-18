using System;

namespace Numbers_1._._.N_with_Step_3
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers are :");
            for (int i = 1; i <= n; i+=3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
