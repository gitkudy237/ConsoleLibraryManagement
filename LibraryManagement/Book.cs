using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement;

public class Book
{
    public int Id { get; set; }
    public string Title { get; } = string.Empty;
    public string Author { get; } = string.Empty;
    public string Isbn { get; set; } = string.Empty;
    public int NumberOfPages { get; }
    public bool IsAvailable { get; set; }

    public Book(string title, string author, string isbn, int numberOfPages)
    {
        Title = title;
        Author = author;
        Isbn = isbn;
        NumberOfPages = numberOfPages;
        IsAvailable = true;
    }
}
