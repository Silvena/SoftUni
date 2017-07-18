using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;


namespace Lab_02RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ');
             Random rnd =  new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int r =  rnd.Next(words.Length);
                    var old  = words[i];
                    words[i] = words[r];
                    words[r] = old;
            }      
            
            Console.WriteLine(string.Join("\r\n",words));
        }
    }
}
