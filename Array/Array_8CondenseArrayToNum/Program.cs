﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_8CondenseArrayToNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            while (arr.Length > 1)
            {

                  int[] condensed= new int[arr.Length -1 ];
                    for (int i = 0; i < arr.Length -1 ; i++)
                    {
               
                       condensed[i] = arr[i] + arr[i + 1];
                        arr = condensed;
                    
                    }
                
                    Console.WriteLine(condensed[0]);
            }
        }
    }
}
