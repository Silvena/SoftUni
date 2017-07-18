using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonalException
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                try
                {
                    if (number < 0)
                    {
                        throw new PersonalExceptions();
                    }
                    Console.WriteLine(number);

                }
                catch (PersonalExceptions pe)
                {

                    Console.WriteLine(pe.Message);
                    return;
                }
               
            }
        }
    }
}
