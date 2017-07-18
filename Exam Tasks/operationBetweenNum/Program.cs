using System;


namespace operationBetweenNum
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var N1 = double.Parse(Console.ReadLine());
            var N2 = double.Parse(Console.ReadLine());
            char input = char.Parse(Console.ReadLine());

            if (input == '+')
            {
                if ((N1 + N2) % 2 == 0) Console.WriteLine($"{N1} + {N2} = {N1 + N2} - even");
                else Console.WriteLine($"{N1} + {N2} = {N1 + N2} - odd");
            }
            if (input == '-')
            {
                if ((N1 - N2) % 2 == 0) Console.WriteLine($"{N1} - {N2} = {N1 - N2} - even");
                else Console.WriteLine($"{N1} - {N2} = {N1 - N2} - odd");
            }
            if (input == '*')
            {
                if ((N1 * N2) % 2 == 0) Console.WriteLine($"{N1} * {N2} = {N1 * N2} - even");
                else Console.WriteLine($"{N1} * {N2} = {N1 * N2} - odd");
            }
            if (input == '/')
            {
                if (N2 == 0) Console.WriteLine($"Cannot divide {N1} by zero");
                else if((N1 / N2) % 2 != 0) Console.WriteLine($"{N1} / {N2} = {N1 / N2:f2}");
                 
            }
            if (input == '%')
            {
                if (N2 == 0) Console.WriteLine($"Cannot divide {N1} by zero");
                else if ((N1 % N2) % 2 != 0) Console.WriteLine($"{N1} % {N2} = {N1 % N2:f2}");
            }
        }
    }
}


