using System;
namespace methodMoreFibonacchi
{
    class Program
    {
        static void Main()
        {
            Fibonacchi();
        }
        static void Fibonacchi()
        {
            var number = long.Parse(Console.ReadLine());
           int fibona = 0;
            /*   int a = 0;
               int b = 1;
               int c = 0;
               Console.WriteLine($"{a}");
               Console.WriteLine($"{b}");
               for (int i = 2; i <= 26; i++)
               {
                   c = a + b;
                   Console.WriteLine($"{c}");
                   a = b;
                   b = c;  */
            /* if ((n == 0) || (n == 1))
             {
                 Console.WriteLine(n);
             }
             else {
                 Console.WriteLine(fibona(n - 1) + fibona(n - 2)); 
             }
             */

            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;

            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            //      return Fib[number];
            Console.WriteLine(Fib);
        }

        }
    }
}
