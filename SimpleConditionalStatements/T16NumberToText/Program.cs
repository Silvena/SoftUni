﻿using System;


namespace T16NumberToText
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string text = "";
            int toTenths = num / 10; 
            int toUnits = num % 10; 
            string[] textUnits = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten",
                                            "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] textTenths = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (num < 0 || num > 100)
            {
                Console.WriteLine("invalid number");
            }
            else if (num >= 0 && num < 20)
            {
                Console.WriteLine(textUnits[num]);
            }
            else if (num >= 20 && num < 100)
            {
                text = textTenths[toTenths];
                if (num % 10 > 0)
                {
                    text += string.Format(" " + textUnits[toUnits]);
                }

                Console.WriteLine(text);

            }
            else if (num == 100)
            {
                Console.WriteLine("one hundred");
            }
        }
    }
}





