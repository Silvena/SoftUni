using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;
using System.Threading.Tasks;

namespace DictionariesMoreEx_07Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomString = Console.ReadLine().Split(' ').ToList();

            //removing all the elements whose length is different than 2
            randomString.RemoveAll(x => x.Length != 2);

            //the loop reverses the digits in the array
            for (int i = randomString.Count - 1; i >= 0; i--)
            {
                var currentReversedText = string.Concat(randomString[i].Reverse());

                randomString[i] = currentReversedText;
            }

            randomString.Reverse();

            foreach (var item in randomString)
            {
                Console.Write(ConvertFromHexadecimalToChars(item));

            }

            Console.WriteLine();
        }

        public static char ConvertFromHexadecimalToChars(string input)
        {
            return (char)Int16.Parse(input, NumberStyles.AllowHexSpecifier);
        }
    }
}
