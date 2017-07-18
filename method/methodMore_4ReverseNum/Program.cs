using System;


namespace methodMore_4ReverseNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string lastDigit = Console.ReadLine();
            int stringLength = lastDigit.Length;
            Console.WriteLine(GetDigitWord(lastDigit, stringLength));
        }
        private static string GetDigitWord(string a, int b)
        {
            string result = "";
            for (int i = b - 1; i >= 0; i--)
            {
                result += a[i];
            }
            return result;
        }

    }
}