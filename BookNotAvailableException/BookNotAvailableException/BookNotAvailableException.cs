using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNotAvailableException
{
    class BookNotAvailableException : Exception
    {
        public BookNotAvailableException(string message) : base(message) { }
    }

    class Library
    {
        private Dictionary<string, bool> books = new Dictionary<string, bool>();

        public Library()
        {
            books["Java"] = true;
            books["Python"] = true;
            books["C++"] = false; 
        }

        public void BorrowBook(string book)
        {
            if (books.ContainsKey(book) && books[book])
            {
                books[book] = false;
                Console.WriteLine(book + " borrowed successfully!");
            }
            else
            {
                throw new BookNotAvailableException(book + " is not available!");
            }
        }
    }
}


