using System;


namespace FallenInLove
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char numSign = '#';
            int leaf = 0;
            int space = 2 * n;
            int middSpace = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}{2}{0}{1}{0}",numSign,new string('~',leaf ),new string('.',space),new string('.',middSpace));
                leaf++;
                space -= 2;
                middSpace += 2;
            }
            int outSide = 1;
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine("{0}{1}{2}{1}{3}{1}{2}{1}{0}", new string('.', outSide), numSign, new string('~', leaf), new string('.', middSpace));

                middSpace -= 2;
                leaf--;
                outSide += 2;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}{1}{1}{0}", new string('.', 2 * n + 2), numSign);
            }
        }
    }
}
