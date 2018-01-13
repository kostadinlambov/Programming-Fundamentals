using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _06.Book_Library_Modification
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Isbn { get; set; }
        public decimal Price { get; set; }
    }

    public class Library
    {
        public string Name { get; set; }

        public List<Book> listOfBooks { get; set; }
    }

    public class Book_Library_Modification
    {
        public static void Main()
        {
            var numberOfBooks = int.Parse(Console.ReadLine());

            var listOfBooks = new List<Book>();

            for (int i = 0; i < numberOfBooks; i++)
            {
                var inputLine = Console.ReadLine()
                    .Split(' ')
                    .ToArray();

                var title = inputLine[0];
                var author = inputLine[1];
                var publisher = inputLine[2];
                var releaseDate = DateTime.ParseExact(
                    inputLine[3],
                    "dd.MM.yyyy",
                    CultureInfo.InvariantCulture);
                var isbn = inputLine[4];
                var price = decimal.Parse(inputLine[5]);

                var book = new Book()
                {
                    Title = title,
                    Author = author,
                    Publisher = publisher,
                    ReleaseDate = releaseDate,
                    Isbn = isbn,
                    Price = price
                };

                listOfBooks.Add(book);
            }

            var date = DateTime.ParseExact(
                Console.ReadLine(),
                "dd.MM.yyyy",
                CultureInfo.InvariantCulture);
    
            var sortedListOfBooks = listOfBooks
                .Where(x => x.ReleaseDate > date)
                .OrderBy(x => x.ReleaseDate)
                .ThenBy(t => t.Title)
                .ToList();

            foreach (var author in sortedListOfBooks)
            {
                Console.WriteLine($"{author.Title} -> " +
                                  $"{author.ReleaseDate:dd.MM.yyyy}");
            }
        }
    }
}
