using System;


namespace Rocket
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int wide = 3 * n;
            int space = 0;
           int dot = n-1;
            int star = (n * 2) - 2;
           
                for (int i = 1; i <= n*4 ; i++)
                {

                    if (i <= n)
                    {
                        Console.Write(new string('.', n / 2));
                        Console.Write(new string('.', dot) +
                            new string('/', 1) +
                            new string(' ', space) +
                            new string('\\', 1) +
                            new string('.', dot));
                        Console.Write(new string('.', n / 2));
                        Console.WriteLine();
                        dot--;
                        space += 2;
                    }
                    /* 
                      if (dot <= n/2)
                      {
                          break;
                      }
                      Console.WriteLine("{0}/{1}\\{0}",
                          new string('.',dot),
                          new string(' ',space));
                      dot -= i;
                      space +=i+1;  */
                }
         
               Console.WriteLine("{0}{1}{0}",
                    new string('.',n /2),
                    new string('*',n*2));

          
                for (int middle = 0; middle <= (n*2)-1; middle++)
                {
                    Console.WriteLine("{0}|{1}|{0}",
                        new string('.', n / 2),
                        new string('\\', (n * 2)-2));
                }
            int dotBottom = n / 2;
            for (int bottom = 1; bottom < (n/2)+1; bottom++)
            {
                
                Console.WriteLine("{0}/{1}\\{0}",
                      new string('.',dotBottom),
                      new string('*',star));
                dotBottom--;
                star +=2;
            }
         
        }
    }
}
