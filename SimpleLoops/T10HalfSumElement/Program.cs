using System;


namespace T10HalfSumElement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;


            for (int i = 0; i < n; i++)
            {
                int inputNum = int.Parse(Console.ReadLine());
                sum += inputNum;

                if (inputNum > max)
                {
                    max = inputNum;
                }
            }
            if (sum == 2 * max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = {0}",max);
            }
            else
            {
                int diff = Math.Abs(max -(sum-max)); 
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0}",diff);
            }

        }
    }
}
