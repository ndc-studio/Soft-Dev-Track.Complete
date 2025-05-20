namespace OOP_Advanced
{
    public class LibrarySystem
    {
        public Library LibraryList { get; set; }
        public List<Patron> Patrons { get; set; } = [];

        public LibrarySystem()
        {
            LibraryList = new Library();
        }

        public void AddPatron(Patron patron)
        {
            Patrons.Add(patron);
            Console.WriteLine($"[LIBRARY SYSTEM SUCCESS]: Patron {patron.PatronName} added to the system!\n");
        }

        public void BorrowBook(string patronName, string title)
        {
            foreach (var Patron in Patrons)
            {
                if (Patron.PatronName == patronName)
                {
                    foreach (var book in LibraryList.Books)
                    {
                        if (book.Title == title && book.IsBorrowed == false)
                        {
                            LibraryList.BorrowBook(title);
                            Patron.BorrowedBook(book);
                        }
                        else if (book.Title == title && book.IsBorrowed == true)
                        {
                            Console.WriteLine($"[LIBRARY SYSTEM ERROR]: This book is actually not available. {patronName} has not received a book.\n");
                        }
                    }
                }
            }
        }

        public void ReturnBook(string patronName, string title)
        {
            foreach (var Patron in Patrons)
            {
                if (Patron.PatronName == patronName)
                {
                    foreach (var book in LibraryList.Books)
                    {
                        if (book.Title == title && book.IsBorrowed == false)
                        {
                            LibraryList.ReturnBook(title);
                            Patron.ReturnBook(book);
                        }
                        else if (book.Title == title && book.IsBorrowed == true)
                        {
                            Console.WriteLine($"[LIBRARY SYSTEM ERROR]: This book is actually not in his possessions. {patronName} has not returned a book.\n");
                        }
                    }
                }
            }
        }

        public void ListBorrowedBooks(string patronName)
        {
            foreach (var Patron in Patrons)
            {
                if (Patron.PatronName == patronName)
                {
                    Console.WriteLine($"[LIBRARY SYSTEM]\n\n[List of borrowed book by {patronName}] :\n");
                    foreach (var book in Patron.BooksList)
                    {
                        book.Display();
                    }
                }
            }
        }
    }
}
