using System;


namespace DrawFort
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int mid = n * 2 - 4 - 2 * (n / 2);
            Console.WriteLine("/{0}\\{1}/{0}\\",
                     new string('^',n/2),
                    new string('_',mid));
            for (int i = 1; i < n -3; i++)
            {
                Console.WriteLine("|{0}|",new string(' ',n*2-2));
            }
            Console.WriteLine("|{0}{1}{0}|", new string(' ', n / 2+1 ), new string('_', mid));
           Console.WriteLine("\\{0}/{1}\\{0}/",new string('_',n/2),new string(' ',mid));
        }
    }
}
