using System;

namespace EnterEvenNumber
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var num = 0;
            do
            {
                try
                {
                    Console.Write("Enter even number: ");
                    num = int.Parse(Console.ReadLine());
                    if (num % 2 == 0)
                    {
                        break;
                    }
                    Console.WriteLine("Entered number is not even.");
                    Console.Write("Enter even number: ");
                    num = int.Parse(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            while (true);
            {
                Console.WriteLine("Even number entered:{0}", num);
            }

        }
    }
}