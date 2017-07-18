using System;


namespace stopFigure
{
   public class Program
    {
      public  static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int dot = n + 1;
            int underDash = 2 * n + 1;
            Console.WriteLine("{0}{1}{0}",
                new string('.',dot),
                new string('_',underDash));
                 underDash -= 2;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}",
                    new string('.',dot-1),
                    new string('_',underDash));
                dot--;
                underDash+=2;
            }
            
            Console.WriteLine("//{0}STOP!{0}\\\\",new string('_',(underDash -5)/2));
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}",new string('.',i),
                    new string('_',underDash));
                underDash-=2;

            }
        }
    }
}
