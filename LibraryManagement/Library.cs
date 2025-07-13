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



        public void AddBook()
        {
            Console.WriteLine("Enter book Title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter book author: ");
            string author = Console.ReadLine();
            Console.WriteLine("Enter the book ISBN: ");
            string isbn = Console.ReadLine();
            Console.WriteLine("Ente the number of pages: ");
            int numberOfPages = Convert.ToInt32(Console.ReadLine());
            var book = new Book(title, author, isbn, numberOfPages);
            book.Id += 1;
            books.Add(book);
        }


        /* To be implemented by Kudy le dev */
        
        //public void RemoveBook(int id) { .. }
        //public void BorrowBook(int id)
        //{ ... }
        //public void ReturnBook(int id) { ... }
        //public void DisplayMenu() { .. }

    }
}
