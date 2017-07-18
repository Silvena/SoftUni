using System;

namespace LettersCombinations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            char letter1 = char.Parse(Console.ReadLine());
            char letter2 = Convert.ToChar(Console.ReadLine());
            char skipLetter = Convert.ToChar(Console.ReadLine());  //moje i taka da se preobrazuva chara
            int count = 0;
            for (char symbol1 = letter1; symbol1 <= letter2; symbol1++)
            {
                if (symbol1 != skipLetter)
                {
                    for (char symbol2 = letter1; symbol2 <= letter2; symbol2++)
                    {
                        if (symbol2 != skipLetter)
                        {
                            for (char symbol3 = letter1; symbol3 <= letter2; symbol3++)
                            {
                                if (symbol3 != skipLetter)
                                {
                                    count++;
                                    string outPut = symbol1.ToString() +
                                                    symbol2.ToString() +
                                                    symbol3.ToString();

                                    Console.Write($"{outPut} ");
                                }
                            }
                        }
                    }

                }
            }
            Console.WriteLine(count);

        }
    }
}
