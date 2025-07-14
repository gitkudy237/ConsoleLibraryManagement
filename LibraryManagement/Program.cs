
using LibraryManagement;

class Program
{
    static void Main(string[] args)
    {
        var library = new Library();
        library.AddBook();
        library.ViewBooks();
        library.SearchBookById(2);
    }
}