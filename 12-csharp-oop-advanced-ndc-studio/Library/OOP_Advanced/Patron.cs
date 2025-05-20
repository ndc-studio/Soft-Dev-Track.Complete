namespace OOP_Advanced
{
    public class Patron
    {
        public string PatronName { get; set; }
        public List<Book> BooksList { get; set; } = [];

        public Patron(string name)
        {
            PatronName = name;
        }

        public void BorrowedBook(Book book)
        {
            BooksList.Add(book);
            Console.WriteLine($"[PATRON SUCCESS]: The book {book.Title} has been borrowed successfully by {PatronName}!\n");
        }

        public void ReturnBook(Book book)
        {
            BooksList.Remove(book);
            Console.WriteLine($"[PATRON SUCCESS]: The book {book.Title} has been returned successfully by {PatronName}\n");
        }
    }
}
