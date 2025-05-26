namespace Tests;

using Xunit;
using LibrarySpace;

public class UnitTest1
{
    [Fact]
    public void Test_AddBook_IntoTheLibrary_IfBookDoesNotExists()
    {
        Book book1 = new Book("To Kill a Mockingbird", "Harper Lee", "original");
        Library library = new();
        var result = library.AddBook(book1);
        Assert.Equal($"\nThe book To Kill a Mockingbird has been added successfully", result);
    }

    [Fact]
    public void Test_AddBook_IntoTheLibrary_IfBookAlreadyExists()
    {
        Book book1 = new Book("To Kill a Mockingbird", "Harper Lee", "original");
        Library library = new();
        library.AddBook(book1);
        var result = library.AddBook(book1);
        Assert.Equal($"\nThe book To Kill a Mockingbird already exist.", result);
    }

    [Fact]
    public void Test_RemoveBook_OfTheLibrary_IfBookExists()
    {
        Book book1 = new Book("To Kill a Mockingbird", "Harper Lee", "original");
        Library library = new();
        library.AddBook(book1);
        var result = library.RemoveBook(book1);
        Assert.Equal($"\nThe book To Kill a Mockingbird has been deleted successfully", result);
    }

    [Fact]
    public void Test_RemoveBook_OfTheLibrary_IfBookDoesNotExists()
    {
        Book book1 = new Book("To Kill a Mockingbird", "Harper Lee", "original");
        Library library = new();
        var result = library.RemoveBook(book1);
        Assert.Equal($"\nThe book To Kill a Mockingbird does not exist.", result);
    }

    [Fact]
    public void Test_BorrowBook_OfTheLibrary_IfBookAreAvailable()
    {
        Book book1 = new Book("To Kill a Mockingbird", "Harper Lee", "original");
        Library library = new();
        library.AddBook(book1);
        var result = library.BorrowBook(book1);
        Assert.Equal($"\nThe book To Kill a Mockingbird has been borrowed sucessfully!", result);
    }

    [Fact]
    public void Test_BorrowBook_OfTheLibrary_IfBookAreUnavailable()
    {
        Book book1 = new Book("To Kill a Mockingbird", "Harper Lee", "original");
        Library library = new();
        library.AddBook(book1);
        library.BorrowBook(book1);
        var result = library.BorrowBook(book1);
        Assert.Equal($"\nThe book To Kill a Mockingbird is already borrowed!", result);
    }

    [Fact]
    public void Test_ReturnBook_IntoTheLibrary_IfBookExists()
    {
        Book book1 = new Book("To Kill a Mockingbird", "Harper Lee", "original");
        Library library = new();
        library.AddBook(book1);
        library.BorrowBook(book1);
        var result = library.ReturnBook(book1); ;
        Assert.Equal($"\nThe book To Kill a Mockingbird has been returned sucessfully!", result);
    }

    [Fact]
    public void Test_ReturnBook_IntoTheLibrary_IfBookIsAlreadyAvailable()
    {
        Book book1 = new Book("To Kill a Mockingbird", "Harper Lee", "original");
        Library library = new();
        library.AddBook(book1);
        var result = library.ReturnBook(book1); ;
        Assert.Equal($"\nThe book To Kill a Mockingbird is already available!", result);
    }
}
