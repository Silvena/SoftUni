using System;


namespace specialNumbers
{
  public  class Program
    {
       public static void Main(string[] args)

        {
            int specNum = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 9; i++)
            {
                for (int a = 1; a <= 9; a++)
                {
                    for (int b = 1; b <= 9; b++)
                    {
                        for (int c = 1; c <= 9; c++)
                        {
                            if ((specNum % i ==0)&& (specNum % a == 0)&& (specNum % b == 0)&& (specNum % c == 0))
                            {
                                Console.Write($"{i}{a}{b}{c} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
