using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        public string Title, Author;
    }

    class EBook : Book
    {
        public double FileSize;
        public string Format;

        public void Show()
        {
            Console.WriteLine(Title + " by " + Author + ", Size: " + FileSize + "MB, Format: " + Format);
        }
    }

}
