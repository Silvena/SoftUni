using System;

namespace m_4DrowSquare
{
    class Program
    {
      /*  static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            header(n);
            middle(n/2);
            header(n);
           
        }
        static void header(int n)
        {
            Console.WriteLine("{0}",new string('-', 2* n));
        }
        static void middle(int n)
        {
            Console.Write('-');
            for (int i = 0; i <= n; i++)
            {
                Console.Write("\\/", n+1);
                
            }
            Console.WriteLine('-');

            Console.Write('-');
            for (int i = 0; i <= n; i++)
            {
                Console.Write("\\/", n + 1);

            }
            Console.WriteLine('-');
        }
      */


        static void PrintHeaderRow( int n)
        {
            Console.WriteLine(new string('-',2*n));
        }
        static void PrintMiddle(int n)
        {
            Console.Write('-');
            for (int i = 0; i < n; i++)
                Console.Write("\\/",n+1);
            Console.WriteLine('-');
        }
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintHeaderRow(n);
            for (int i = 0; i < n - 2; i++)
                PrintMiddle(i);
            PrintHeaderRow(n);

            
        }
    }
}
