using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicat
{
    class Program
    {

        static void Main(string[] args)
        {

            int[] arr = { 10, 33, -22, 0, 7, -111, 333, -1000, 333 };

            for (int i = 0; i <= arr.Length - 1; i++)
            {

                for (int ii = i + 1; ii <= arr.Length - 1; ii++)
                {
                    if (arr[i] > arr[ii])
                    {
                        int temp = arr[ii];
                        arr[ii] = arr[i];
                        arr[i] = temp;
                    }
                }
             
  Console.WriteLine(arr[i]);
            } 

            /*        for (int i = 0; i < arr.Length; i++)
                    {

                    }

                    int result = arr.Length / 2;
                    Console.WriteLine(arr[result]);

            */

        }
    }
}

