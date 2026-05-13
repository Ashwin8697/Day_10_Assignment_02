namespace LibraryManagementSystem
{
    public class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }

        public bool IsBorrowed { get; set; }

        // Borrow book
        public void Borrow()
        {
            IsBorrowed = true;
        }

        // Return book
        public void Return()
        {
            IsBorrowed = false;
        }
    }
}