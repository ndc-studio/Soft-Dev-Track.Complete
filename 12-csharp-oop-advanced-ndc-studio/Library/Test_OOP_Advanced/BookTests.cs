namespace Test;

using Xunit;
using OOP_Advanced;
using System;
using System.IO;

public class BookTests
{
    [Fact]
    public void Borrow_SetToTrue_WhenBookIsAvailable()
    {
        var book = new Book("1984", "George Orwell", "Dystopia");
        book.Borrow();
        Assert.True(book.IsBorrowed);
    }

    [Fact]
    public void Borrow_NoChange_WhenBookIsAlreadyBorred()
    {
        var book = new Book("1984", "George Orwell", "Dystopia");
        book.Borrow();
        var result = book.Borrow();

        Assert.True(book.IsBorrowed);
        Assert.Equal("[BOOK ERROR]: The book \"1984\" is already borrowed..\n", result);
    }

    [Fact]
    public void ReturnBook_SetToFalse_WhenBookIsReturned()
    {
        var book = new Book("1984", "George Orwell", "Dystopia");
        book.Borrow();
        book.ReturnBook();

        Assert.False(book.IsBorrowed);
    }

    [Fact]
    public void ReturnBook_NoChange_WhenBookIsAlreadyReturned()
    {
        var book = new Book("1984", "George Orwell", "Dystopia");
        book.ReturnBook();
        var result = book.ReturnBook();

        Assert.False(book.IsBorrowed);
        Assert.Equal($"[BOOK ERROR]: The book \"1984\" was not borrowed..\n", result);
    }
}

public class LibraryTests
{
    [Fact]
    public void AddBook_ShouldAddBookToLibrary()
    {
        var library = new Library();
        var book = new Book("1984", "George Orwell", "Dystopia");

        library.AddBook(book);

        library.BorrowBook("1984");
        Assert.True(book.IsBorrowed);
    }

    [Fact]
    public void BorrowBook_ShouldBorrow_WhenBookIsAvailable()
    {
        var library = new Library();
        var book = new Book("1984", "George Orwell", "Dystopia");
        library.AddBook(book);

        library.BorrowBook("1984");

        Assert.True(book.IsBorrowed);
    }

    [Fact]
    public void BorrowBook_ShouldNotBorrow_WhenBookNotFound()
    {
        var library = new Library();
        library.BorrowBook("Unknown Book");
    }

    [Fact]
    public void ReturnBook_ShouldReturn_WhenBookIsBorrowed()
    {
        var library = new Library();
        var book = new Book("1984", "George Orwell", "Dystopia");
        library.AddBook(book);
        book.Borrow();

        library.ReturnBook("1984");

        Assert.False(book.IsBorrowed);
    }

    [Fact]
    public void ListBooksByGenre_ShouldReturnOnlyBooksInThatGenre()
    {
        var library = new Library();
        var book1 = new Book("1984", "George Orwell", "Dystopia");
        var book2 = new Book("Brave New World", "Aldous Huxley", "Dystopia");
        var book3 = new Book("Pride and Prejudice", "Jane Austen", "Romance");

        library.AddBook(book1);
        library.AddBook(book2);
        library.AddBook(book3);

        var originalOut = Console.Out;
        using var sw = new StringWriter();
        Console.SetOut(sw);

        library.ListBooksByGenre("Dystopia");

        Console.SetOut(originalOut);

        var output = sw.ToString();
        Assert.Contains("1984", output);
        Assert.Contains("Brave New World", output);
        Assert.DoesNotContain("Pride and Prejudice", output);
    }
}
