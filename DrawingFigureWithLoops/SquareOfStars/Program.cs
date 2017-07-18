using System;
public class Program
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)

        {
            Console.Write("*");
            for (int b = 1; b < n; b++)
            {
                Console.Write(" *");
                
                
            }
            Console.WriteLine();
        }
    }
}

