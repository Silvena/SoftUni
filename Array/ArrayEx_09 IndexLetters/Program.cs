using System;

namespace ArrayEx_09_IndexLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            foreach (var letter in text)
            {
                Console.WriteLine(string.Join(" -> ",letter,letter - 'a' ));
            }
        }
    }
}
