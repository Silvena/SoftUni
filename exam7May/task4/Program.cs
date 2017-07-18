using System;

namespace task4
{
  public  class Program
    {
       public static void Main(string[] args)
        {
            var capacity = double.Parse(Console.ReadLine());
            var countFan = double.Parse(Console.ReadLine());
         
            var A = 0.0;
            var B = 0.0;
            var C = 0.0;
            var D = 0.0;
            for (int i = 1; i <= countFan; i++)
            {
                Char sector = char.Parse(Console.ReadLine());
                if (sector == 'A')
                {
                    A ++;
                 
                }
                else if (sector == 'B')
                {
                    B++;
                   
                }
                else if (sector == 'V')
                {
                    C++;
                   
                }
                else if (sector == 'G')
                {
                    D++;
                   
                }

            } 
            Console.WriteLine($"{A / countFan * 100:f2}%");
            Console.WriteLine($"{B / countFan * 100:f2}%");
            Console.WriteLine($"{C / countFan * 100:f2}%");
            Console.WriteLine($"{D / countFan * 100:f2}%");
            Console.WriteLine($"{countFan / capacity*100:f2}%");

        }
    }
}
