using System;
namespace arrow
{
    public class Program
    {
        public static void Main(string[] args)
        {

            for (int i = -10; i <= 10; i++)
            {

                Console.WriteLine(new string('*', 10 - Math.Abs(i)));
                }
        }
    }
}
