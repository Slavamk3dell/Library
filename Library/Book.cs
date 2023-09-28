using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public int Year { get; private set; }
        public string Text { get; private set; }

        public Book(string title, string author, int year, string text)
        {
            Title = title;
            Author = author;
            Year = year;
            Text = text;
        }

        public override string ToString()
        {
            return $"{Title} by {Author} ({Year})";
        }

        public void DisplayTextOfBook()
        {
            Console.WriteLine($"Text: {Text}");
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            if (obj is not Book another)
                return false;

            return another.Title == Title && another.Author == Author &&
                another.Year == Year;
        }
    }
}
