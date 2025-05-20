using System;

namespace LibrarySpace
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }
        public bool IsBorrowed { get; set; }

        public Book(string title, string author, string type)
        {
            Title = title;
            Author = author;
            Type = type;
            IsBorrowed = false;
        }

        public void DisplayBook()
        {
            Console.WriteLine($"\nTitle: {Title} - Author: {Author} - Type: {Type} - Availability: { (IsBorrowed ? "Unavailable" : "Available") }");
        }
    }
}