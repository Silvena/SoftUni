using System;
namespace drawFort
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var w = 2 * n;
            var h = n -2;
            var chafka = n/2;
            var space = 0;
            var underDash = 0;
            if (n >= 5 )
            {
                underDash = n / 2;
                Console.WriteLine("/{0}\\{1}/{0}\\",
            new string('^', chafka),
            new string('_', underDash));
            }
            else
            {  Console.WriteLine("/{0}\\{1}/{0}\\",
            new string('^', chafka),
            new string(' ', space));
            }
            for (int i = 1; i <= h; i++)
            {
                Console.WriteLine("|{0}|",new string(' ',w-2));
            }
            if (n >= 5)
            {
                underDash = n / 2;
                Console.WriteLine("\\{0}/{1}\\{0}/",
            new string('_', underDash),
            new string('~',chafka));
            }
            else
            {
                Console.WriteLine("\\{0}/{1}\\{0}/",
            new string('_', chafka),
            new string(' ', space));
            }
        }
    }
}
