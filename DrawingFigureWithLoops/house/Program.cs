using System;


namespace house
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var even = 1;
            if (n % 2 == 0)
                even = 2;
            for (int i = 0; i < (n + 1) /2; i++)
            {
                Console.WriteLine("{0}{1}{0}", new string('-', (n - even) / 2),
                    new string('*', even));
                even += 2;
            }
            for (int z = 0; z < (n /2); z++)
            {
                Console.WriteLine("|{0}|",
                    new string('*',n-2));
            }
        }
    }
}
