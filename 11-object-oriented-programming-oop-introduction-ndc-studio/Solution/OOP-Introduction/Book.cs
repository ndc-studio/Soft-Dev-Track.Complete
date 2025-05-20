namespace OOP_Introduction
{
    public class Book
    {
        public string? Author { get; set; }
        public string? Title { get; init; }
        public int Pages { get; set; }

        public Book() { }
        public Book(string author, string title, int pages)
        {
            Author = author;
            Title = title;
            Pages = pages;
        }

        public string Display()
        {
            return $"Author: {Author} - Title: {Title} - Pages: {Pages}";
        }
    }
}
