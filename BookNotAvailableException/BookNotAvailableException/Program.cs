namespace BookNotAvailableException
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library();

            try
            {
                Console.Write("Enter book name: ");
                string book = Console.ReadLine();
                lib.BorrowBook(book);
            }
            catch (BookNotAvailableException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}
