namespace OOP_Advanced
{
    public class Library
    {

        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void ListBooks()
        {
            Console.WriteLine("[LIBRARY]\n\n[List of all books] :\n");
            foreach (var book in Books)
            {
                Console.WriteLine(book.Display());
            }
        }

        public void ListBooksByGenre(string genre)
        {
            Console.WriteLine("[LIBRARY]\n\n[List by gender] :\n");
            foreach (var book in Books)
            {
                if (book.Genre == genre)
                {
                    book.Display();
                }
            }
        }

        public void BorrowBook(string title)
        {
            foreach (var book in Books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    book.Borrow();
                }
            }
        }

        public void ReturnBook(string title)
        {
            foreach (var book in Books)
            {
                if (book.Title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    book.ReturnBook();
                }
            }
        }
    }
}
