using System;

namespace methodMore_2MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            GetMax();
        }
        static void GetMax()
        {
          int  a = int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());
           int c = int.Parse(Console.ReadLine());
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if( c > max)
            {
                max = c;
            }
            Console.WriteLine(max);
        }
    }
}
