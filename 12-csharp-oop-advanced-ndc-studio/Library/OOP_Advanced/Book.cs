namespace OOP_Advanced
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public bool IsBorrowed { get; set; }

        public Book(string title, string author, string genre)
        {
            Title = title;
            Author = author;
            Genre = genre;
            IsBorrowed = false;
        }

        public string Borrow()
        {
            if (!IsBorrowed)
            {
                IsBorrowed = true;
                string msg = $"[BOOK SUCCESS]: The book: {Title} has been borrowed!\n";
                Console.WriteLine(msg);
                return msg;
            }
            else
            {
                string alert = $"[BOOK ERROR]: The book \"{Title}\" is already borrowed..\n";
                Console.WriteLine(alert);
                return alert;
            }
        }

        public string ReturnBook()
        {
            if (IsBorrowed)
            {
                IsBorrowed = false;
                string msg = $"[BOOK SUCCESS]: The book: {Title}, has been returned successfully!\n";
                Console.WriteLine(msg);
                return msg;
            }
            else
            {
                string alert = $"[BOOK ERROR]: The book \"{Title}\" was not borrowed..\n";
                Console.WriteLine(alert);
                return alert;
            }
        }

        public string Display()
        {
            string msg = $"Title: {Title} - Author: {Author} - Status: {(!IsBorrowed ? "Available" : "Borrowed")}\n";
            Console.WriteLine(msg);
            return msg;
        }
    }
}