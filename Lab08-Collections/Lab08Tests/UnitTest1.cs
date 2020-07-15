using System;
using Xunit;
using Lab08_Collections;
using Lab08_Collections.classes;

namespace Lab08Tests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddBooksToTheLibrary()
        {
            // Arrange
            Library<Book> Library = new Library<Book>();

            // Act

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

            int expected = 6;
            int actual = Library.Count();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CanRemoveBooksFromTheLibrary()
        {
            // Arrange
            Library<Book> Library = new Library<Book>();

            // Act

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

            // Removing a Book
            Library.Remove(3);

            int expected = 5;
            int actual = Library.Count();
            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CannotRemoveBooksFromTheLibraryThatDoNotExist()
        {
            // Arrange
            Library<Book> Library = new Library<Book>();

            // Act

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

            // Removing a Book, but it will do nothing
            Library.Remove(8);

            int expected = 6;
            int actual = Library.Count();
            // Assert
            Assert.Equal(expected, actual);
        }

    }
}
