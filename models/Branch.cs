using System.Collections.Generic;

namespace library.Models
{
    class Branch
    {
        public List<Book> Available { get; set; }
        public List<Book> CheckedOut { get; set; }

        public void InitialInventory()
        {
            // a.k.a. the most important books
            Book h = new Book("The Hobbit", "J.R.R. Tolkien", Genre.Fantasy, 304);
            Book fr = new Book("The Fellowship of the Ring", "J.R.R. Tolkien", Genre.Fantasy, 479);
            Book tt = new Book("The Two Towers", "J.R.R. Tolkien", Genre.Fantasy, 415);
            Book rk = new Book("The Return of the King", "J.R.R. Tolkien", Genre.Fantasy, 347);
            Available.AddRange(new Book[] { h, fr, tt, rk });
        }

        public Branch()
        {
            Available = new List<Book>();
            CheckedOut = new List<Book>();
        }
    }
}