using System;


namespace T8OddEvenSum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;


            for (int i = 0; i <  n; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += input;
                }
                else
                {
                    oddSum += input;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes, sum = {0}", evenSum);
            }
            else
            {
                int diff = Math.Abs(evenSum - oddSum);
                Console.WriteLine("No, diff = {0} ", diff);
            }
        }
    }
}