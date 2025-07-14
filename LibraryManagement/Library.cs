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
