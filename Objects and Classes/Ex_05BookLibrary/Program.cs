using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Ex_05BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbooks = int.Parse(Console.ReadLine());
            List<Book> books = new List<Book>();
            for (int i = 0; i < numbooks; i++)
            {
                books.Add(ReadBooks(Console.ReadLine()));
            }
            Library librari = new Library { Name = "Library", Books = books };
            Dictionary<string, decimal> authors = new Dictionary<string, decimal>();

            foreach (Book book in librari.Books)
            {
                if (authors.ContainsKey(book.Author))
                {
                    authors[book.Author] += book.Price;

                }
                else
                {
                    authors[book.Author] = book.Price;
                }
            }
            foreach (var pair in authors.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                 Console.WriteLine($"{pair.Key} -> {pair.Value:f2}");
            }
           
        }
  

   static Book ReadBooks(string input)
        {
            string[] tokens = input.Split(' ');
            string title = tokens[0];
            string author = tokens[1];
            string publisher = tokens[2];
            DateTime releseDate = DateTime.ParseExact(tokens[3],"dd.MM.yyyy", CultureInfo.InvariantCulture);
            string isbn = tokens[4];
            decimal price = decimal.Parse(tokens[5]);

            return new Book {Title = title, Author = author, Publisher = publisher,ReleaseDate = releseDate,ISBN = isbn, Price = price};
        }
  
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN  { get; set; }
        public decimal Price { get; set; }
    }
    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
