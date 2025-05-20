using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace LibrarySpace
{
    public class Library
    {
        public HashSet<string> BorrowedBookTitle { get; set; }
        public HashSet<string> AllowedBookTitle { get; set; }
        public List<Book> Books { get; set; }

        public Library()
        {
            BorrowedBookTitle = [];
            AllowedBookTitle = [];
            Books = [];
        }

        public void AddBook(Book book)
        {
            if (Books.Contains(book))
            {
                Console.WriteLine($"\nThe book {book.Title} already exist.");
                return;
            }
            else
            {
                AllowedBookTitle.Add(book.Title);
                Books.Add(book);
                Console.WriteLine($"\nThe book {book.Title} has been added successfully");
            }
        }

        public void RemoveBook(Book book)
        {
            if (Books.Contains(book))
            {
                if (BorrowedBookTitle.Contains(book.Title))
                {
                    BorrowedBookTitle.Remove(book.Title);
                }

                if (AllowedBookTitle.Contains(book.Title))
                {
                    AllowedBookTitle.Remove(book.Title);
                }

                Books.Remove(book);
                Console.WriteLine($"\nThe book {book.Title} has been deleted successfully");
            }

            else
            {
                Console.WriteLine($"\nThe book {book.Title} does not exist.");
                return;
            }
        }

        public void BorrowBook(Book book)
        {
            if (BorrowedBookTitle.Contains(book.Title))
            {
                Console.WriteLine($"\nThe book {book.Title} is already borrowed!");
            }
            else
            {
                book.IsBorrowed = true;
                BorrowedBookTitle.Add(book.Title);
                AllowedBookTitle.Remove(book.Title);
                Console.WriteLine($"\nThe book {book.Title} has been borrowed sucessfully!");
            }
        }

        public void ReturnBook(Book book)
        {
            if (BorrowedBookTitle.Contains(book.Title))
            {
                book.IsBorrowed = false;
                BorrowedBookTitle.Remove(book.Title);
                AllowedBookTitle.Add(book.Title);
                Console.WriteLine($"\nThe book {book.Title} has been returned sucessfully!");
            }
            else
            {
                Console.WriteLine($"\nThe book {book.Title} is already available!");
            }
        }

        public void SearchByName(string title)
        {
            foreach (var book in Books)
            {
                if (book.Title == title)
                {
                    book.DisplayBook();
                }
            }
        }

        public void DisplayAll()
        {
            foreach (var book in Books)
            {
                book.DisplayBook();
            }     
        }
    }
}