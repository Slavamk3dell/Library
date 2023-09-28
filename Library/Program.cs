using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main()
        {
            Library library = new();

            while (true)
            {
                Console.WriteLine("\nLibrary Menu:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Display Books");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        Console.Write("Enter book title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter author name: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter publication year: ");
                        int year;
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
                            goto case "1";
                        }
                        Console.Write("Enter book text: ");
                        string text = Console.ReadLine();

                        Console.Clear();

                        Book newBook = new(title, author, year, text);
                        library.AddBook(newBook);
                        break;

                    case "2":
                        Console.Clear();
                        library.WriteListOfBooksIfExisted();
                        if (library.IsBooksPresent())
                        {
                            Console.Write("Enter number of the book to remove: ");
                            string choiceOfBook = Console.ReadLine();
                            Console.Clear();
                            library.RemoveBook(choiceOfBook);
                        }
                        break;

                    case "3":
                        Console.Clear();
                        library.DisplayBooks();
                        break;

                    case "4":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Спасибо за пользование этой говносистемой");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
