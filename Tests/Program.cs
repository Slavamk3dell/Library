using LibraryNameSpace;

namespace Tests
{
    internal class Program
    {
        private static void Main()
        {
            var library = new Library();

            Console.Clear();
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter author name: ");
            string author = Console.ReadLine();
            Console.Write("Enter publication year: ");
            int year = 0;
            year = int.Parse(Console.ReadLine());

            Console.Write("Enter book text: ");
            string text = Console.ReadLine();

            Console.Clear();

            Book newBook = new(title, author, year, text);
            library.AddBook(newBook);
        }
    }
}