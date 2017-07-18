using System;


namespace SoftUniLogo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int h = 4 * n - 2;
            int wide = 12 * n - 5;

            int ctrUp = 0;
            int dots = (wide - 1) / 2;
            int dotsDown = 2;
            int ctrDots = 0;
            int ctr = 0;
            int hightHat = n * 2;
            int downRows1 = n - 2;
            int points = n * 3 - 1;

            for (int i = 1; i <= h; i++)
            {    // up of hat
                if (i >= 1 && i <= hightHat)
                {
                    Console.WriteLine("{0}{1}{0}",
                        new string('.', dots - ctrDots),
                        new string('#', 1 + ctrUp),
                        new string('.', dots - ctrDots));
                    ctrUp += 6;
                    ctrDots += 3;
                }
                else if (i > hightHat && i <= hightHat + downRows1)
                {
                    // meaddle oh hat
                    Console.WriteLine("|{0}{1}{0}.",
                        new string('.', dotsDown + ctr),
                        new string('#', wide - dotsDown * 2 - ctr * 2 - 2),
                        new string('.', dotsDown + ctr));

                    ctr += 3;

                }
                else if (i >= hightHat + downRows1 && i <= h - 1)
                {   // brefore end
                    Console.WriteLine("|{0}{1}{0}.",
                        new string('.', points - 3),
                        new string('#', wide -2 -2 * (points - 3)),
                        new string('.', points - 3));
                }
                else if (i == h)
                {   // last row
                    Console.WriteLine("@{0}{1}{0}.",
                        new string('.', points - 3),
                        new string('#', wide - 2 - 2 * (points - 3)),
                        new string('.', points - 3));
                }
            }

        }
    }
}
