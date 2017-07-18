using System;

namespace Hourglass
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int h = 2 * n + 1;
            int wide = 2 * n + 1;
            int dot = 1;
            int klomba = 1;
            int star = 1;
            var klomba2 = wide-6 ;
            var space = 0;
             Console.WriteLine(new string('*',wide));
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('.',dot),
                new string('*',star),
                new string(' ', wide-4));
             
         for (int i = 1; i <= wide ; i++)
            {
                if (i >= 3 && i <= n)
                {
              
                    Console.WriteLine("{0}{1}{2}{1}{0}",
                           new string('.', dot + 1),
                           new string('*', star),
                           new string('@', klomba2));
                    dot++;
                klomba2 -= 2;
                }

       }
           var dot2 = wide / 2 ;
            Console.WriteLine("{0}{1}{0}",new string('.',dot2), 
                new string('*',star));
         for (int i = 1; i <= wide; i++)
               {
                if (i >= 3 && i <= n)
                {

                    Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}",
                           new string('.', dot ),
                           new string('*', star),
                           new string(' ',space),
                           new string('@', klomba));
                    dot--;
                    space++;
                }
            }  
           
            Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('.', dot),
                new string('*', star),
                new string('@',wide -4));

            Console.WriteLine(new string('*', wide));     
        }
    }
}
