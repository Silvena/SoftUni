using System;

using System.Linq;


namespace Array_5RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            double[] roundedNums = (double[])arr.Clone();
            roundedNums = arr
                .Select(element => Math.Round(element, MidpointRounding.AwayFromZero))
                .ToArray();

            foreach (var arrElement in arr.Zip(roundedNums, Tuple.Create))
            {
                Console.WriteLine($"{arrElement.Item1} => {arrElement.Item1}");
            }
           
        }
    }
}
/*
            var input = Console.ReadLine();
            string[] words = input.Split(' ');
            char[] arr = words.Select(char.Parse).ToArray();
             shorter way to get data form console
             *  
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
              */