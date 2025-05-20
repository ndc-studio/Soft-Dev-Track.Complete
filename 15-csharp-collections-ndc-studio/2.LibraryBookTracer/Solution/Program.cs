namespace LibrarySpace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Creates few books */
            Book book1 = new Book("To Kill a Mockingbird", "Harper Lee", "original");
            Book book2 = new Book("1984", "George Orwell", "pocket");
            Book book3 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "collector");
            Book book4 = new Book("Pride and Prejudice", "Jane Austen", "original");
            Book book5 = new Book("The Hobbit", "J.R.R. Tolkien", "collector");
            Book book6 = new Book("The Catcher in the Rye", "J.D. Salinger", "pocket");

            Library library = new Library();
            Console.WriteLine("\n----------------------");
            Console.WriteLine("[CREATE FEW BOOKS]");
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book5);
            library.AddBook(book6);
            Console.WriteLine("\n----------------------");

            Console.WriteLine("\n----------------------");
            Console.WriteLine("[REMOVE BOOK]");
            library.RemoveBook(book6);
            Console.WriteLine("\n----------------------");

            Console.WriteLine("\n----------------------");
            Console.WriteLine("[BORROW BOOKS]");
            library.BorrowBook(book4);
            library.BorrowBook(book5);
            library.BorrowBook(book2);
            Console.WriteLine("\n----------------------");

            Console.WriteLine("\n----------------------");
            Console.WriteLine("[RETURN BOOK]");
            library.ReturnBook(book5);
            Console.WriteLine("\n----------------------");

            Console.WriteLine("\n----------------------");
            Console.WriteLine("\n[SEARCHING BY NAME] (\"1984\")");
            library.SearchByName("1984");
            Console.WriteLine("\n----------------------");

            Console.WriteLine("\n----------------------");
            Console.WriteLine("\n[DISPLAY ALL BOOKS]");
            library.DisplayAll();
            Console.WriteLine("\n----------------------");

            /* Exit system */
            Console.WriteLine("\n\n |    EXIT    | \n");
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}