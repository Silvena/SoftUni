﻿using System;


namespace NumberPyramid
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var num = 1;
            for (var row = 1; row <= n; row++)
            {
                for (var col = 1; col <= row; col++)
                {
                    if (col > 1)
             
                        Console.Write(" ");
                        Console.Write(num);
                        num++;
               
                    if (num > n) break;
                }
                Console.WriteLine();
                if (num > n) break;
            }
        }
    }
}