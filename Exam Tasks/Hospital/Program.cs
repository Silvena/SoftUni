using System;

namespace Hospital
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int doc = 7;
            int treated = 0;
            int unTreated = 0;
            for (int i = 1; i <= period; i++)
            {
                int pacient = int.Parse(Console.ReadLine());
                if (i % 3 == 0 &&unTreated > treated)
                {
                       doc++;
                    

                }

                if (pacient < doc)
                {
                    treated += pacient;
                }
                else
                {

                    unTreated += (pacient - doc);
                    treated += doc;
                }

            }

            Console.WriteLine("Treated patients: {0}.", treated);
            Console.WriteLine("Untreated patients: {0}.", unTreated);

        }
    }
}
