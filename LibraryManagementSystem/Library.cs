using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    public class Library
    {
        // List of books
        public List<Book> Books { get; set; }

        // List of borrowers
        public List<Borrower> Borrowers { get; set; }

        // Constructor
        public Library()
        {
            Books = new List<Book>();
            Borrowers = new List<Borrower>();
        }

        // Add new book
        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        // Register borrower
        public void RegisterBorrower(Borrower borrower)
        {
            Borrowers.Add(borrower);
        }

        // Borrow a book
        public void BorrowBook(string isbn, string libraryCardNumber)
        {
            Book book = Books.FirstOrDefault(b => b.ISBN == isbn);

            Borrower borrower =
                Borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber);

            if (book != null && borrower != null && !book.IsBorrowed)
            {
                book.Borrow();

                borrower.BorrowBook(book);
            }
        }

        // Return a book
        public void ReturnBook(string isbn, string libraryCardNumber)
        {
            Book book = Books.FirstOrDefault(b => b.ISBN == isbn);

            Borrower borrower =
                Borrowers.FirstOrDefault(b => b.LibraryCardNumber == libraryCardNumber);

            if (book != null && borrower != null)
            {
                book.Return();

                borrower.ReturnBook(book);
            }
        }

        // View books
        public List<Book> ViewBooks()
        {
            return Books;
        }

        // View borrowers
        public List<Borrower> ViewBorrowers()
        {
            return Borrowers;
        }
    }
}