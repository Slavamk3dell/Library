namespace LibraryNameSpace
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public int Year { get; }
        public string Text { get; }

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
    }
}
