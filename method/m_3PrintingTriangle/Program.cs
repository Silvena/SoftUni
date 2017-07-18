using System;

namespace m_3PrintingTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            middle(n);
        }
        static void StartLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write( i + " ");
            }
            Console.WriteLine();
        }
        static void middle( int n)
        {
            for (int line = 1; line <= n; line++)
            {
                StartLine(1, line);
            }
            for (int line = n- 1; line >= 1; line--)
            {
                StartLine(1 ,line);
            }
        }
    }
}
