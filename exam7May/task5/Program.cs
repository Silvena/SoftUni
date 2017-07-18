using System;

namespace task5
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int wide = (2 * n) - 1;
            int height = (n / 2) + 4;
            var dot = 1;
            var dot1 = 1;
           var space = n - 5;
            Console.WriteLine("{0}{1}{0}{1}{0}",
                new string('@',1),
                new string(' ',wide/2-1));
           Console.WriteLine("{0}{1}{2}{1}{0}",
                new string('*', 2),
                new string(' ', wide / 2 - 2),
                new string('*',1)); 
          
            
        for (int i = 0; i < height - 6; i++)
            {
               
                        Console.WriteLine("*{0}*{1}*{2}*{1}*{0}*",
                            new string('.', dot),
                            new string(' ', space),
                        new string('.',dot1 + i * 2));
                      
                        dot++;
                        space-=2; 
            }  
           
            
                Console.WriteLine("*{0}*{1}*{0}*",
                   new string('.', n / 2 -1),
                   new string('.', n- 3 ));
           
            Console.WriteLine("*{0}{1}{2}{1}{0}*",
                new string('.',n/2),
                new string('*', n /2-2),
                new string('.' ,1));
            Console.WriteLine(new string('*', 2*n -1));
            Console.WriteLine(new string('*', 2 * n - 1));
        }
    }
}
