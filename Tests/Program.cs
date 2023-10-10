using LibraryNameSpace;

namespace Tests
{
    internal class Program
    {
        private static string Title;
        private static string Author;
        private static int Year;
        private static string Text;
        private static LibraryNameSpace.Library Library;
        private static void Main()
        {
            Library = new LibraryNameSpace.Library();
            int countOfBooksBefore = Library.CountOfBooks();

            // Положительный тест кейс
            Console.WriteLine("Положительный тест кейс AddBook:");
            if (ResultOfTestCase() && countOfBooksBefore < Library.CountOfBooks())
                Console.WriteLine("Положительный тест кейс пройден успешно!!!\n");
            else
                Console.WriteLine("Положительный тест кейс провален!!!\n");

            // Отрицательный тест кейс
            Console.WriteLine("Отрицательный тест кейс AddBook:");
            if (ResultOfTestCase() && countOfBooksBefore < Library.CountOfBooks())
                Console.WriteLine("Отрицательный тест кейс пройден успешно!!!\n");
            else
                Console.WriteLine("Отрицательный тест кейс провален!!!\n");
        }

        private static bool ResultOfTestCase()
        {
            Console.Write("Enter book title: ");
            Title = Console.ReadLine();
            Console.Write("Enter author name: ");
            Author = Console.ReadLine();
            Console.Write("Enter publication year: ");
            try
            {
                Year = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                return false;
            }

            Console.Write("Enter book text: ");
            Text = Console.ReadLine();

            Book newBook = new(Title, Author, Year, Text);
            Library.AddBook(newBook);

            Console.Clear();
            return true;
        }
    }
}