using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace FileAndEx_07AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random(56);
            var phrases = File.ReadAllLines(@"..\..\phrases.txt"); //{ "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            var events = File.ReadAllLines(@"..\..\events.txt");//{ "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
            var author = File.ReadAllLines(@"..\..\author.txt"); //{ "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
            var cities = File.ReadAllLines(@"..\..\cities.txt");//{ "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            var numOfMessages = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfMessages; i++)
            {
                var randomPhrases = phrases[random.Next(phrases.Length)];
                var randomEvents = events[random.Next(events.Length)];
                var randomAuthor = author[random.Next(author.Length)];
                var randomCitices = cities[random.Next(cities.Length)];

                Console.WriteLine($"{randomPhrases} {randomEvents} {randomAuthor} – {randomCitices}.");
            }

        }
    }
}
