using System;
using System.Collections.Generic;

namespace Library
{
    public class Program
    {
        static Library library = new Library();
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nLibrary Menu:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Display Books");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddBook();
                }

                else if (choice == "2")
                {
                    RemoveBook();
                }

                else if (choice == "3")
                {
                    DisplayBooks();
                }

                else if (choice == "4")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Спасибо за пользование этой программы!!!");
                    Environment.Exit(0); 
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Invalid choice. Please try again."); 
                }
            }
        }

        public static void DisplayBooks()
        {
            Console.Clear();
            library.DisplayBooks();
        }

        public static void RemoveBook()
        {
            Console.Clear();
            library.WriteListOfBooksIfExisted();
            if (library.IsBooksPresent())
            {
                Console.Write("Enter number of the book to remove: ");
                int choiceOfBook = 0;
                try
                {
                    choiceOfBook = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный ввод. Повторите попытку!!!");
                    Thread.Sleep(2000);
                    Console.ForegroundColor = ConsoleColor.White;
                    RemoveBook();
                    return;
                }
                if (choiceOfBook < 1 || choiceOfBook > library.CountOfBooks())
                {
                    Console.WriteLine("Неверный номер книги. Повторите попытку!!!");
                    Thread.Sleep(2000);
                    RemoveBook();
                    return;
                }
                Console.Clear();
                library.RemoveBook(choiceOfBook);
            }
        }

        public static void AddBook()
        {
            Console.Clear();
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter author name: ");
            string author = Console.ReadLine();
            Console.Write("Enter publication year: ");
            int year = 0;
            try
            {
                year = int.Parse(Console.ReadLine());
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
            string text = Console.ReadLine();

            Console.Clear();

            Book newBook = new(title, author, year, text);
            library.AddBook(newBook);
        }
    }
}
