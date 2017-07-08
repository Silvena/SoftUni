using System;
using System.Linq;

namespace Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                var command = line
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                switch (command[0])
                {
                    case "exchange":
                        input = Exchange(input, int.Parse(command[1]));
                        break;
                    case "max":
                    case "min":
                        MaxAndMin(input, command[0], command[1]);
                        // var count = Console.ReadLine();
                        break;
                    case "first":
                    case "last":
                        FirstAndLAst(input, command[0], int.Parse(command[1]), command[2]);
                        break;
                }
            }
            PrintInput(input);
        }
        private static void FirstAndLAst(int[] input, string commands, int count, string evenOrOdd)
        {

            if (count > input.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var filter = FilterEvenOrOdd(input, evenOrOdd);
            int[] result;
            if (commands == "first")
            {
                result = filter.Take(count).ToArray();
            }
            else
            {
                result = filter.Reverse().Take(count).Reverse().ToArray();
            }
            PrintInput(result);
        }
        private static void PrintInput(int[] input)
        {
            var inputAsArray = string.Join(", ", input);

            Console.WriteLine($"[{inputAsArray}]");
        }
        private static int[] FilterEvenOrOdd(int[] input, string evenOrOdd)
        {
            return input
                .Where(n => evenOrOdd == "even"
                 ? n % 2 == 0
                 : n % 2 == 1)
                 .ToArray();
        }
        private static void MaxAndMin(int[] input, string command, string evenOrOdd)
        {

            var filter = FilterEvenOrOdd(input, evenOrOdd);
            if (!filter.Any())
            {
                Console.WriteLine("No matches");
                return;
            }

            var result = command == "max"
                 ? filter.Max()
                 : filter.Min();

            Console.WriteLine(Array.LastIndexOf(input, result));
        }
        private static int[] Exchange(int[] input, int index)
        {
            if (index < 0 || index >= input.Length)
            {
                Console.WriteLine("Invalid index");
                return input;
            }
            var left = input.Take(index + 1);
            var right = input.Skip(index + 1);
            return right.Concat(left).ToArray();
        }
    }
}
