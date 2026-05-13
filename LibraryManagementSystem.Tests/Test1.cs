using Microsoft.VisualStudio.TestTools.UnitTesting;
using LibraryManagementSystem;

namespace LibraryManagementSystem.Tests
{
    [TestClass]
    public class UnitTest1
    {
        // Test adding a book
        [TestMethod]
        public void AddBookTest()
        {
            Library library = new Library();

            Book book = new Book
            {
                Title = "C# Basics",
                Author = "Ashwin",
                ISBN = "101"
            };

            library.AddBook(book);

            Assert.AreEqual(1, library.Books.Count);
        }

        // Test borrower registration
        [TestMethod]
        public void RegisterBorrowerTest()
        {
            Library library = new Library();

            Borrower borrower = new Borrower
            {
                Name = "Raj",
                LibraryCardNumber = "L001"
            };

            library.RegisterBorrower(borrower);

            Assert.AreEqual(1, library.Borrowers.Count);
        }

        // Test borrowing a book
        [TestMethod]
        public void BorrowBookTest()
        {
            Library library = new Library();

            Book book = new Book
            {
                Title = "ASP.NET",
                Author = "Wipro",
                ISBN = "202"
            };

            Borrower borrower = new Borrower
            {
                Name = "Ashwin",
                LibraryCardNumber = "L002"
            };

            library.AddBook(book);

            library.RegisterBorrower(borrower);

            library.BorrowBook("202", "L002");

            // Check if book is borrowed
            Assert.IsTrue(book.IsBorrowed);

            // Check if borrower has the book
            Assert.AreEqual(1, borrower.BorrowedBooks.Count);
        }

        // Test returning a book
        [TestMethod]
        public void ReturnBookTest()
        {
            Library library = new Library();

            Book book = new Book
            {
                Title = "SQL",
                Author = "Admin",
                ISBN = "303"
            };

            Borrower borrower = new Borrower
            {
                Name = "Rohit",
                LibraryCardNumber = "L003"
            };

            library.AddBook(book);

            library.RegisterBorrower(borrower);

            // Borrow book first
            library.BorrowBook("303", "L003");

            // Return book
            library.ReturnBook("303", "L003");

            // Check if book is available again
            Assert.IsFalse(book.IsBorrowed);

            // Check if book removed from borrower list
            Assert.AreEqual(0, borrower.BorrowedBooks.Count);
        }

        // Test viewing books
        [TestMethod]
        public void ViewBooksTest()
        {
            Library library = new Library();

            Book book1 = new Book
            {
                Title = "C#",
                Author = "John",
                ISBN = "111"
            };

            Book book2 = new Book
            {
                Title = "SQL",
                Author = "Mike",
                ISBN = "222"
            };

            library.AddBook(book1);

            library.AddBook(book2);

            var books = library.ViewBooks();

            Assert.AreEqual(2, books.Count);
        }

        // Test viewing borrowers
        [TestMethod]
        public void ViewBorrowersTest()
        {
            Library library = new Library();

            Borrower borrower1 = new Borrower
            {
                Name = "Ashwin",
                LibraryCardNumber = "L100"
            };

            Borrower borrower2 = new Borrower
            {
                Name = "Raj",
                LibraryCardNumber = "L200"
            };

            library.RegisterBorrower(borrower1);

            library.RegisterBorrower(borrower2);

            var borrowers = library.ViewBorrowers();

            Assert.AreEqual(2, borrowers.Count);
        }
    }
}