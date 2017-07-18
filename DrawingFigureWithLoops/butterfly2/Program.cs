using System;


namespace butterfly2
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var w = 2 * (n - 2) + 1;
            var h = 2 * n - 1;
            var halfButt = n - 1;
            var space = 1;

             Console.WriteLine("{0}\\{1}/{0}",new string('*',n-2),new string(' ',space));
            
        }
    }
}
