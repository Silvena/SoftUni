using System;

namespace StupidPasswordGenerator
{
   public class Program
    {
       public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
           var l = int.Parse(Console.ReadLine());
            for (int i1 = 1; i1 <= n; i1++)
            {
                for (var b2 = 1; b2 <= n; b2++)
                {
                    for (var c2 = 'a'; c2 < 'a'+ l; c2++)
                    {
                        for (var c3 = 'a'; c3 < 'a'+l ; c3++)
                        {
                            for (var i3 = Math.Max(i1,b2)+1; i3 <= n; i3++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ",i1,b2,c2,c3,i3);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
