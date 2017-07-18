using System;


namespace Bradva
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var width = 5 * n;
            var leftDashes = 3 * n;
            var middleDashes = 0;
            var rightDashes = width - leftDashes - middleDashes - 2;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', leftDashes),
                    new string('-', middleDashes),
                    new string('-', rightDashes));
                middleDashes++;
                rightDashes--;
            }
            middleDashes--;
            rightDashes++;
            for (int p = 0; p < n / 2; p++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                   new string('*', leftDashes),
                   new string('-', middleDashes),
                   new string('-', rightDashes));
            }
            for (int i = 0; i < n / 2 - 1; i++)
            {
                Console.WriteLine("{0}*{1}*{2}",
                    new string('-', leftDashes),
                    new string('-', middleDashes),
                    new string('-', rightDashes));
           
            leftDashes--;
            middleDashes += 2;
            rightDashes--;
             }
           // leftDashes+=1;
           // middleDashes --;
            //rightDashes=1;

            Console.WriteLine("{0}*{1}*{2}",
                        new string('-', leftDashes),
                        new string('*', middleDashes),
                        new string('-', rightDashes));
        }
    }
}
