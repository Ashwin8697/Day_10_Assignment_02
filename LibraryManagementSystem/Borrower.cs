using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class Borrower
    {
        public string Name { get; set; }

        public string LibraryCardNumber { get; set; }

        // List of borrowed books
        public List<Book> BorrowedBooks { get; set; }

        // Constructor
        public Borrower()
        {
            BorrowedBooks = new List<Book>();
        }

        // Borrow a book
        public void BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
        }

        // Return a book
        public void ReturnBook(Book book)
        {
            BorrowedBooks.Remove(book);
        }
    }
}