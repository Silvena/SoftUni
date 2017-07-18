using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Globalization;

namespace FileAndEx_09BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!File.Exists("myFile.txt"))     
            {
                File.Create("myFile.txt");
            }
            var lines = File.ReadAllText("myFile.txt");

           // Console.WriteLine(lines);
///
            List<Book> books = new List<Book>();
        
              
            Library librari = new Library { Name = "Library", Books = books };
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            Dictionary<string, DateTime> BooksByDate = new Dictionary<string, DateTime>();

            foreach (Book book in librari.Books)
            {
                if (book.ReleaseDate.CompareTo(date) > 0)
                {
                    BooksByDate.Add(book.Title, book.ReleaseDate);

                }
            }
            foreach (var pair in BooksByDate.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value:dd.MM.yyyy}");
            }

        }


        static Book ReadBooks(string input)
        {
            string[] tokens = input.Split(' ');
            string title = tokens[0];
            string author = tokens[1];
            string publisher = tokens[2];
            DateTime releseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            string isbn = tokens[4];
            decimal price = decimal.Parse(tokens[5]);

            return new Book { Title = title, Author = author, Publisher = publisher, ReleaseDate = releseDate, ISBN = isbn, Price = price };
           
     } 

    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
    