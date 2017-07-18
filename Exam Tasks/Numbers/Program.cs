using System;

namespace Numbers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            int first = (num / 100)% 10;
            int second = (num / 10) % 10;
            int third = num % 10;
            int Row = first + second;
            int Col = first + third;
            for (int i = 0; i < Row; i++)
            {
                for (int z = 0; z < Col; z++)
                {

                    if (num % 5 == 0)
                    {
                        num -= first;
                    }
                    else if (num % 3 == 0)
                    {
                        num -= second;
                    }
                    else
                    {
                        num += third;

                    }
   
                   Console.Write("{0} ",num);
                    
                }
                Console.WriteLine();
            }
        }

    }
}
