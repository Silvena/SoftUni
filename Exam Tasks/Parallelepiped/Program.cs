using System;


namespace Parallelepiped
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int h = 4 * n + 4;
            int wide = 3 * n + 1;
            int waves = n - 2;
            int dot = 0;
            int colDot = wide - waves - 3;
            int row = h / 2- 1;
             Console.WriteLine("+{0}+{1}",
                             new string('~', waves),
                             new string('.', wide - waves - 2 ));
        for (int i = 1; i <= row  ; i++)
            {
                Console.WriteLine("|{0}\\{1}\\{2}",
                 new string('.', dot),
                 new string('~',waves),
                 new string('.', colDot));
                dot++;
                colDot--;
            }
            int dot2 = 1;
            int colDot2 = wide - waves - 3;
            Console.WriteLine("\\{0}|{1}|", new string('.',colDot2),new string('~',waves));

            for (int i = 1; i <= row -1  ; i++)
            {
                Console.WriteLine("{0}\\{1}|{2}|",
                    new string('.', dot2),
                    new string('.', colDot2-i),
                    new string('~',waves));
                dot2++;
                colDot--;
            }
          
            Console.WriteLine("{0}+{1}+",
                new string('.', wide - waves - 2),
                new string('~', waves));


        }
    }
}
