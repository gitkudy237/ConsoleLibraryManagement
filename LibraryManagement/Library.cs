using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Library
    {
        public List<Book> books = new List<Book>();

        /* To be implemented by Clovis le pro */
        //public void AddBook(Book book) { ... }
        //public void ViewBooks() { ... }
        //public void SearchBookByTitle(string title) { ... }
        //public void SearchBookById(string id) { .. }

        /* To be implemented by Kudy le dev */
        public void RemoveBook(int id) { .. }
        public void BorrowBook(int id)
        { ... }
        public void ReturnBook(int id) { ... }
        public void DisplayMenu() { .. }

    }
}
