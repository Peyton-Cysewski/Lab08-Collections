using System;
using System.Collections.Generic;
using System.Text;

namespace Lab08_Collections.classes
{
    public class Book
    {
        public string Title { get; set; }
        public Author BookAuthor { get; set; }

        public Genre BookGenre { get; set; }

        public enum Genre
        {
            SciFi = 1,
            Fantasy,
            Horror,
            Drama,
            Action,
            Thriller
        }
    }
}
