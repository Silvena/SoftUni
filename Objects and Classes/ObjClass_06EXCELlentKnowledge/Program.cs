﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjClass_06EXCELlentKnowledge
{
    class Program
    {
        static void Main(string[] args)
        {
            Application xlApp = new Application();
            Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\Softuni\0.2 Tech Module - May 2017\Projects\10.ObjectsClassesFilesAndExceptiosMoreExers
                                                        \06. EXCELlent Knowledge\sample_table.xlsx");
            Worksheet xlWorksheet = xlWorksheets.Sheets[1];
            Range xlRange = xlWorksheet.UsedRange;

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 1 && i != 1)
                    {
                        Console.WriteLine();
                    }

                    Console.Write(xlRange.Cells[i, j].Value + "|");
                }
            }
        }
    }

}
