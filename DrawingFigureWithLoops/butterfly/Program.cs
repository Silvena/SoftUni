using System;


namespace butterfly
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int halfWide = n - 1;

            for (int all = 0; all < halfWide -1; all++)
            {

                if (all % 2 != 0)
                {
                    Console.WriteLine("{0}\\ /{0}",
                               new string('-', halfWide -1));
                }
                else
                {
                    Console.WriteLine("{0}\\ /{0}",
                            new string('*', halfWide -1));
                }

            }
        Console.WriteLine("{0} @ {0}",new string(' ', halfWide -1));

            for (int down = 0; down < halfWide -1; down++)
            {
                if (down % 2 != 0)
                {
                    Console.WriteLine("{0}/ \\{0}",
                               new string('-', halfWide -1));
                }
                else
                {
                    Console.WriteLine("{0}/ \\{0}",
                            new string('*', halfWide-1));
                }


            }
        }
    }
}

