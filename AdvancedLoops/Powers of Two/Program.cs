using System;


namespace Powers_of_Two
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 0; i <= n ; i++)
            {
                    Console.WriteLine(result);
                result = result * 2;

              
            }
        }
    }
}
