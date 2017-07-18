using System;


namespace VacantionMarokoAlaska
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string seasson = Console.ReadLine().ToLower();

            if (budget <= 1000)
            {
                var settlement = "Camp";
                if (seasson == "summer")
                {
                    var location = "Alaska";
                    double disscount = budget * 0.65;
                    Console.WriteLine($"{location} - {settlement} - {disscount:f2}");
                }
                else
                {
                    var location = "Morocco";
                    double disscount = budget * 0.45;
                    Console.WriteLine($"{location} - {settlement} - {disscount:f2}");
                }
            }
            else if (budget <= 3000)
            {
                var settlement = "Hut";
                if (seasson == "summer")
                {
                    var location = "Alaska";
                    double disscount = budget * 0.80;
                    Console.WriteLine($"{location} - {settlement} - {disscount:f2}");
                }
                else
                {
                    var location = "Morocco";
                    double disscount = budget * 0.60;
                    Console.WriteLine($"{location} - {settlement} - {disscount:f2}");
                }
            }
            else if (budget > 3000)
            {
                var settlement = "Hotel";
                if (seasson == "summer")
                {
                    var location = "Alaska";
                    double disscount = budget * 0.90;
                    Console.WriteLine($"{location} - {settlement} - {disscount:f2}");
                }
                else
                {
                    var location = "Morocco";
                    double disscount = budget * 0.90;
                    Console.WriteLine($"{location} - {settlement} - {disscount:f2}");
                }
            }
        }
    }
}