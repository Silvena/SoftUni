
using System;
namespace Т12EqualPairs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int newPair = 0;
            int prevPair = 0;
            int maxDiff = 1;
            int counter = 0;
            for (int i = 1; i <= num; i++)
            {
                int odd = int.Parse(Console.ReadLine());
                int even = int.Parse(Console.ReadLine());
                newPair = odd + even;
                
                if (newPair == prevPair)
                {
                    counter += 1;
                }
                if (maxDiff < Math.Abs(prevPair - newPair) && i >= 2)
                    maxDiff = Math.Abs(prevPair - newPair);
                if (newPair != prevPair)
                {
                  prevPair = newPair;
                }
            }
            if (counter == num - 1)
                Console.WriteLine("Yes, value={0}", newPair);
            else
                Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
    }

}


