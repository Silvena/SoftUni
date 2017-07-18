using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Lab_02LineNumb
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] file = File.ReadAllLines("input.txt");

            for (int i = 0; i < file.Length; i++)
            {
                File.AppendAllLines("output.txt",
                    $"{i+1}. {file[i]}{Environment.??}");
            }
            

        }
    }
}
