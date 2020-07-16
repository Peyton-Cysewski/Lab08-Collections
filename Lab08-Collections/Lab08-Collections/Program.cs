using Lab08_Collections.classes;
using System;
using System.Collections.Generic;
using System.Net;

namespace Lab08_Collections
{
    public class Program
    {
        public static Library<Book> Library { get; set; }
        public static Dictionary<int, Book> BookBag { get; set; }
        static void Main(string[] args)
        {
            Library = new Library<Book>();
            BookBag = new Dictionary<int, Book>();
            LoadBooks();
            UserInterface();
        }

        public static void LoadBooks()
        {
            // Create Books

            // Book 1
            Book EndersGame = new Book();
            Author author1 = new Author("Orson", "Scott Card");
            EndersGame.Title = "Ender\'s Game";
            EndersGame.BookAuthor = author1;
            EndersGame.BookGenre = (Book.Genre)1;

            // Book 2
            Book LotR = new Book();
            Author author2 = new Author("J.R.R.", "Tolkien");
            LotR.Title = "The Lord of the Rings: The Fellowship of the Ring";
            LotR.BookAuthor = author2;
            LotR.BookGenre = (Book.Genre)2;

            // Book 3
            Book TheShining = new Book();
            Author author3 = new Author("Stephen", "King");
            TheShining.Title = "The Shining";
            TheShining.BookAuthor = author3;
            TheShining.BookGenre = (Book.Genre)3;

            // Book 4
            Book Hamlet = new Book();
            Author author4 = new Author("William", "Shakespeare");
            Hamlet.Title = "Hamlet";
            Hamlet.BookAuthor = author4;
            Hamlet.BookGenre = (Book.Genre)4;

            // Book 5
            Book TheMazeRunner = new Book();
            Author author5 = new Author("James", "Dashner");
            TheMazeRunner.Title = "The Maze Runner";
            TheMazeRunner.BookAuthor = author5;
            TheMazeRunner.BookGenre = (Book.Genre)5;

            // Book 6
            Book RedOctober = new Book();
            Author author6 = new Author("Tom", "Clancy");
            RedOctober.Title = "The Hunt for Red October";
            RedOctober.BookAuthor = author6;
            RedOctober.BookGenre = (Book.Genre)6;

            // Adding Books to the Library
            Library.Add(EndersGame);
            Library.Add(LotR);
            Library.Add(TheShining);
            Library.Add(Hamlet);
            Library.Add(TheMazeRunner);
            Library.Add(RedOctober);
        }

        public static void UserInterface()
        {
            Console.WriteLine("Welcome to Phil\'s Lending Library! Please choose an option below to get started:");
            bool quit = false;
            while (!quit)
            {
                Console.WriteLine();
                Console.WriteLine("1. View All Books");
                Console.WriteLine("2. Add a Book");
                Console.WriteLine("3. Borrow a Book");
                Console.WriteLine("4. Return a Book");
                Console.WriteLine("5. View Book Bag");
                Console.WriteLine("6. Exit");
                Console.WriteLine();

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        foreach (Book novel in Library)
                        {
                            Console.WriteLine($"{novel.Title} By: {novel.BookAuthor.FirstName} {novel.BookAuthor.LastName} -- {novel.BookGenre} genre");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Please enter the title of the book:");
                        string title = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Please enter the author\'s first name:");
                        string first = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Please enter the author\'s last name:");
                        string last = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("Please select the genre of this book");
                        int genre = 0;
                        while (genre < 1 || genre > 6)
                        {
                            foreach (int i in Enum.GetValues(typeof(Book.Genre)))
                            {
                                Console.WriteLine($"{i}. {(Book.Genre)i}");
                            }
                            string genreAnswer = Console.ReadLine();
                            genre = Int32.TryParse(genreAnswer, out int result) ? result : 0;
                        }
                        Book book = new Book();
                        book.Title = title;
                        book.BookAuthor = new Author(first, last);
                        book.BookGenre = (Book.Genre)genre;
                        Library.Add(book);
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "6":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Selection Please Try Again");
                        break;
                }
            }
        }
    }
}
