using System;


namespace Fox
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var wide = 2 * n + 3;
           
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('*',i+1)+'\\'+
                    new string('-', 2 * n - 1 -2*i)+'/'+ 
                    new string('*', i + 1));

            }
          for (int b = 0; b < n/3; b++)
          {
                Console.WriteLine('|'+
                    new string('*', n /2 + b)+'\\'+
                    new string('*', n - 2 * b)+'/'+
                    new string('*', n / 2 + b)+'|');
          }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(new string('-', i + 1) + '\\' +
                    new string('*', 2 * n - 1 - 2 * i) + '/' +
                    new string('-', i + 1));

            }
        }
    }
}
