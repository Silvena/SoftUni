using System;
public class Program
{
    public static void Main()
    {
        string mounth = Console.ReadLine().ToLower();
        int nights = int.Parse(Console.ReadLine());
        double studio = 0;
        double apartment = 0;

        if (mounth.Equals("may") || mounth.Equals("october"))
        {
            if (nights > 14)
            {
                // double sum = 65 - (0.1 * 65);
                studio = 50 - 0.3 * 50;
                apartment = 65 - (0.1 * 65);

            }
            else if (nights > 7)
            {
                studio = 50 - 0.05 * 50;
                apartment = 65;
            }
            else
            {
                studio = 50;
                apartment = 65;
            }
        }
        else if (mounth == "june" || mounth == "september")
        {
            if (nights > 14)
            {
                double sum2 = 68.70 - (0.1 * 68.70);
                double sum3 = 75.20 - 0.2 * 75.20;
                studio = sum3;
                apartment = sum2;
            }
            else
            {
                studio = 75.20;
                apartment = 68.70;
            }
        }
        else if (mounth == "july" || mounth == "august")
        {
            if (nights > 14)
            {
                double sum4 = 77 - (0.1 * 77);
                studio = 76;
                apartment = sum4;
            }
            else
            {
                studio = 76;
                apartment = 77;
            }
        }
        Console.WriteLine("Apartment: {0:f2} lv.", apartment * nights);
        Console.WriteLine("Studio: {0:f2} lv.", studio * nights);
    }
}