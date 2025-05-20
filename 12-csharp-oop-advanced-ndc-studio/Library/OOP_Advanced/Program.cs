namespace OOP_Advanced
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Create an instence of LibrarySystem*/
            var library = new LibrarySystem();

            /* Create few books objects */
            var book = new Book("1984", "George Orwell", "Dystopia");
            var book1= new Book("To Kill a Mockingbird", "Harper Lee", "Classic");
            var book2 = new Book("Brave New World", "Aldous Huxley", "Science Fiction");
            var book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "Classic");
            var book4 = new Book("The Catcher in the Rye", "J.D. Salinger", "Coming-of-age");
            var book5 = new Book("Pride and Prejudice", "Jane Austen", "Romance");
            var book6 = new Book("Fahrenheit 451", "Ray Bradbury", "Dystopia");
            var book7 = new Book("Moby Dick", "Herman Melville", "Adventure");
            var book8 = new Book("The Hobbit", "J.R.R. Tolkien", "Fantasy");
            var book9 = new Book("Dracula", "Bram Stoker", "Horror");

            /* Create few patrons objects */
            var patron = new Patron("Stephan");
            var patron1 = new Patron("Hugo");
            var patron2 = new Patron("Antoine");
            var patron3 = new Patron("Manu");
            var patron4 = new Patron("Jordan");

            /* Add all books in the LibrarySystem List*/
            library.LibraryList.AddBook(book);
            library.LibraryList.AddBook(book1);
            library.LibraryList.AddBook(book2);
            library.LibraryList.AddBook(book3);
            library.LibraryList.AddBook(book4);
            library.LibraryList.AddBook(book5);
            library.LibraryList.AddBook(book6);
            library.LibraryList.AddBook(book7);
            library.LibraryList.AddBook(book8);
            library.LibraryList.AddBook(book9);

            /* Register some patrons into LibrarySystem Patrons List*/
            library.AddPatron(patron);
            library.AddPatron(patron1);
            library.AddPatron(patron2);
            library.AddPatron(patron3);
            library.AddPatron(patron4);


            library.BorrowBook("Stephan", "Fahrenheit 451");
            library.BorrowBook("Stephan", "The Hobbit");
            library.BorrowBook("Stephan", "Moby Dick");
            library.BorrowBook("Stephan", "Dracula");


            library.BorrowBook("Hugo", "The Hobbit");
            library.ReturnBook("Stephan", "The Hobbit");
            library.ReturnBook("Jordan", "The Hobbit");

            library.ListBorrowedBooks("Stephan");

            library.LibraryList.ListBooksByGenre("Dystopia");

            Console.WriteLine("Press any key for exiting");
            Console.ReadKey();
        }
    }
}
