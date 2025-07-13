using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Library
    {
        public List<Book> books = new()
        {
            new Book("title1", "author1", "1239-27892-297", 150),
            new Book("title2", "author2", "1452-28992-297", 3000),
            new Book("title3", "author3", "1239-27892-297", 456),
        };

        /* To be implemented by Clovis le pro */
        //public void AddBook(Book book) { ... }
        //public void ViewBooks() { ... }
        //public void SearchBookByTitle(string title) { ... }
        //public void SearchBookById(string id) { .. }


        public void RemoveBook(int id)
        {
            var existingBook = books.FirstOrDefault(b => b.Id == id);
            if (existingBook is null)
            {
                Console.WriteLine("Book not found");
                return;
            }

            books.Remove(existingBook);
        }
        public void BorrowBook(int id)
        {  }
        public void ReturnBook(int id) {  }
        public void DisplayMenu() {  }

    }
}
