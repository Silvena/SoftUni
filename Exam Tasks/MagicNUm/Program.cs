using System;


namespace MagicNUm
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= 9; i++)
            {
                for (int a = 0; a <= 9; a++)
                {
                    for (int b = 0; b <= 9; b++)
                    {
                        for (int c = 0; c <= 9; c++)
                        {
                            for (int d = 0; d <= 9; d++)
                            {
                                for (int e = 0; e <= 9; e++)
                                {
                                     
                                    if (i * a * b * c * d * e == n)
                                    {
                                        Console.Write($"{i}{a}{b}{c}{d}{e} ");
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }
    }
}
