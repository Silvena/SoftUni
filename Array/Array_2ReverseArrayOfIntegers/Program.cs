using System;

namespace Array_2ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var arr = new int[number];
            for (int i = 0; i < number; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = number - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
               
            }
            Console.WriteLine();
        }
    }
}
