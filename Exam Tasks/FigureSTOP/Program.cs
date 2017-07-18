using System;


namespace FigureSTOP
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int underLine = n * 2 - 1;
            int dot = n;
            string leftDash = "//";
            string rightDash = @"\\";
            Console.WriteLine("{0}{1}{0}",new string('.',dot),new string('_',underLine+2));
            for (int i = 0; i < n * 2 ; i++)
            {
                Console.WriteLine("{0}{1}{2}{3}{0}",new string('.',dot), leftDash ,new string('_', underLine),rightDash);
                if (i ==n-1)
                {
                    Console.WriteLine("{0}{1}STOP!{1}{2}",rightDash , new string('_', underLine / 2 - 1), leftDash);
                    

                    leftDash = @"\\";
                   rightDash = "//";
                }
       
            if (i >= n)
            {
                underLine -= 2;
                dot++;
            }
            else
            {
                underLine += 2;
                dot--;
            }
            }
        }
    }
}
