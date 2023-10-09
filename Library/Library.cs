namespace LibraryNameSpace
{
    public class Library
    {
        private readonly List<Book> _books = new();
        public void AddBook(Book book)
        {
            _books.Add(book);
            Console.WriteLine($"Added book: {book}");
        }

        public void RemoveBook(int indexOfBook)
        {
            Console.WriteLine($"Removed book: {_books[indexOfBook - 1]}");
            _books.RemoveAt(indexOfBook - 1);
        }

        public void DisplayBooks()
        {
            while (true)
            {
                WriteListOfBooksIfExisted();
                if (!IsBooksPresent())
                    break;
                
                Console.Write("\nВыберите книгу: ");
                int indexOfBook;
                try
                {
                    indexOfBook = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный ввод. Нужно вводить число!!!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }
                finally
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (indexOfBook > _books.Count || indexOfBook < 1)
                {
                    Console.WriteLine("Такой книги нет в списке!!!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }

                _books[indexOfBook - 1].DisplayTextOfBook();
                break;

            }
        }

        public void WriteListOfBooksIfExisted()
        {
            if (IsBooksPresent())
            {
                Console.WriteLine("Library Books:");
                for (var i = 0; i < _books.Count; i++)
                    Console.WriteLine($"{i + 1}) {_books[i]}");
            }
            else
                Console.WriteLine("В библиотеке нет книг");
        }

        public bool IsBooksPresent()
        {
            return _books.Count != 0;
        }

        public int CountOfBooks()
        {
            return _books.Count;
        }
    }
}
