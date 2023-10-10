using LibraryNameSpace;

namespace Tests
{
    internal class Program
    {
        private static void Main()
        {
            var library = new LibraryNameSpace.Library();

            // Положительный тест кейс
            Console.WriteLine("Положительный тест кейс:");
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter author name: ");
            string author = Console.ReadLine();
            Console.Write("Enter publication year: ");
            int year = 0;
            bool result = true;
            try
            {
                year = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                result = false;
            }

            Console.Write("Enter book text: ");
            string text = Console.ReadLine();

            Console.Clear();

            if (result)
            {
                Book newBook = new(title, author, year, text);
                library.AddBook(newBook);
                Console.WriteLine("Положительный тест кейс прошел успешно!!!");
            }
            else
            {
                Console.WriteLine("Положительный тест кейс провален!!!");
            }

            // Отрицательный тест кейс

            Console.WriteLine("\nОтрицательный тест кейс:");
            Console.Write("Enter book title: ");
            title = Console.ReadLine();
            Console.Write("Enter author name: ");
            title = Console.ReadLine();
            Console.Write("Enter publication year: ");
            year = 0;
            result = true;
            try
            {
                year = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                result = false;
            }

            Console.Write("Enter book text: ");
            text = Console.ReadLine();

            Console.Clear();

            if (result)
            {
                Book newBook = new(title, author, year, text);
                library.AddBook(newBook);
                Console.WriteLine("Отрицательный тест кейс прошел успешно!!!");
            }
            else
            {
                Console.WriteLine("Отрицательный тест кейс провален!!!");
            }
        }
    }
}