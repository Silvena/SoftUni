using System;

namespace christmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.Write(new string(' ',n));
            Console.WriteLine(" |");
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n-i));
                Console.Write(new string('*',i));
                Console.Write(" ");
                Console.Write("|");
                Console.Write(" ");
                Console.WriteLine(new string('*', i));

                /* Console.WriteLine("{0}{1} | {1}",new string(' ', n-i),new string('*',i) );    */
            }

        }
    }
}
