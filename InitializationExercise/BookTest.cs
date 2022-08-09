using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitializationExercise
{
    internal class BookTest
    {
        public static void Main()
        {
            Book b = new Book("aba", "ahah",true);
            Book b1 = new Book("aba", "ahah");
            Book b2 = new Book("aba");
            Book b3 = new Book();

        }
    }
}
