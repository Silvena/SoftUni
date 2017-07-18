using System;


namespace Fibonacci
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int first = 1;
            int second = 1;
            
            for (int i = 0; i < n-1; i++)
            {
                int next = first + second;
                first = second;
                second = next;

            }
            Console.WriteLine(second);
        }
    }
}
