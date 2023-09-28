using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library
    {
        private readonly List<Book> books = new();
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Added book: {book}");
        }

        public void RemoveBook(int indexOfBook)
        {
            Console.WriteLine($"Removed book: {books[indexOfBook - 1]}");
            books.RemoveAt(indexOfBook - 1);
        }

        public void DisplayBooks()
        {
            while (true)
            {
                WriteListOfBooksIfExisted();
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
                if (indexOfBook > books.Count || indexOfBook < 1)
                {
                    Console.WriteLine("Такой книги нет в списке!!!");
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }

                books[indexOfBook - 1].DisplayTextOfBook();
                break;

            }
        }

        public void WriteListOfBooksIfExisted()
        {
            if (IsBooksPresent())
            {
                Console.WriteLine("Library Books:");
                for (int i = 0; i < books.Count; i++)
                    Console.WriteLine($"{i + 1}) {books[i]}");
            }
            else
                Console.WriteLine("В библиотеке нет книг");
        }

        public bool IsBooksPresent()
        {
            return books.Count != 0;
        }

        public int CountOfBooks()
        {
            return books.Count;
        }
    }
}
