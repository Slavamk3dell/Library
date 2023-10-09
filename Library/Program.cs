using LibraryNameSpace;

namespace Library
{
    public class Program
    {
        private static readonly LibraryNameSpace.Library Library = new();

        private static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nLibrary Menu:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Display Books");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddBook();
                        break;
                    case "2":
                        RemoveBook();
                        break;
                    case "3":
                        DisplayBooks();
                        break;
                    case "4":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Спасибо за пользование этой программы!!!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        public static void DisplayBooks()
        {
            Console.Clear();
            Library.DisplayBooks();
        }

        public static void RemoveBook()
        {
            while (true)
            {
                var choice = 0;
                Console.Clear();
                Library.WriteListOfBooksIfExisted();
                if (!Library.IsBooksPresent()) return;
                Console.Write("Enter number of the book to remove: ");
                var choiceOfBook = Console.ReadLine() ?? "1";
                if (IsInt32(choiceOfBook))
                {
                    choice = int.Parse(choiceOfBook);
                    if (choice < 1 || choice > Library.CountOfBooks())
                    {
                        PrintMessageAboutOutOfRange();
                        continue;
                    }
                }
                else
                {
                    PrintMessageAboutIntError();
                    continue;
                }

                Console.Clear();
                Library.RemoveBook(choice);
                break;
            }
        }

        private static void PrintMessageAboutOutOfRange()
        {
            Console.WriteLine("Неверный номер книги. Повторите попытку!!!");
            Thread.Sleep(2000);
        }
        private static void PrintMessageAboutIntError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"Неверный ввод числа. Повторите попытку!!!");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void AddBook()
        {
            Console.Clear();
            Console.Write("Enter book title: ");
            var title = Console.ReadLine();
            Console.Write("Enter author name: ");
            var author = Console.ReadLine();
            Console.Write("Enter publication year: ");
            int year;
            try
            {
                year = int.Parse(Console.ReadLine() ?? "2023");
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR 404");
                Console.WriteLine("Нужно вводить число!!!");
                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.White;
                AddBook();
                return;
            }
            Console.Write("Enter book text: ");
            var text = Console.ReadLine();

            Console.Clear();
            Book newBook = new(title, author, year, text);
            Library.AddBook(newBook);
        }

        private static bool IsInt32(string str)
        {
            return int.TryParse(str, out _);
        }
    }
}
