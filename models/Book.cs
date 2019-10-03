namespace library.Models
{
    class Book
    {
        public string Title { get; private set; }
        public string Author { get; private set; }
        public Genre Genre { get; private set; }
        public int Pages { get; private set; }

        public Book(string title, string author, Genre genre, int pages)
        {
            Title = title;
            Author = author;
            Genre = genre;
            Pages = pages;
        }
    }

    enum Genre
    {
        Adventure,
        Romance,
        SciFi,
        Fantasy,
        Horror,
        Mystery,
        Nonfiction
    }
}