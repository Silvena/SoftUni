﻿using System;


namespace NumberTable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (var row = 0; row < n; row++)
            {
                for (var col = 0; col < n; col++)
                {
                    var num = row + col+1;
                    if (num > n) num = 2 * n - num;
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }

        }
    }

}
