using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement
{
    public class Library
    {
        public List<Book> books = new()
        {
            new Book(1,"title1", "author1", "1239-27892-297", 150),
            new Book(2,"title2", "author2", "1452-28992-297", 3000),
            new Book(3,"title3", "author3", "1239-27892-297", 456),
        };

        /* To be implemented by Clovis le pro */
        //public void AddBook(Book book) { ... }
        //public void ViewBooks() { ... }
        //public void SearchBookByTitle(string title) { ... }
        //public void SearchBookById(string id) { .. }




        public void AddBook()
        {
            Console.WriteLine("Enter book Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter book Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter book author: ");
            string author = Console.ReadLine();
            Console.Write("Enter the book ISBN: ");
            string isbn = Console.ReadLine();
            Console.Write("Ente the number of pages: ");
            int numberOfPages = Convert.ToInt32(Console.ReadLine());
            var book = new Book(id, title, author, isbn, numberOfPages);
            books.Add(book);
            Console.WriteLine("Book Successfully added.");
        }

        public void ViewBooks()
        {
            foreach (var book in books)
            {
                Console.WriteLine($"Title {book.Title}\nAuthor: {book.Author}\nISBN: {book.Isbn}\nNumber of page: {book.NumberOfPages}");
                Console.WriteLine("\n\n");
            }
        }

        public void SearchBookById(int id)
        {
            var book = books.FirstOrDefault(b => b.Id == id);
            if(book  != null)
                Console.WriteLine($"Title {book.Title}\nAuthor: {book.Author}\nISBN: {book.Isbn}\nNumber of page: {book.NumberOfPages}");
            else
                Console.WriteLine("Book is not found");

        }
        public void SearchBookByTitle(string title)
        {
            var matchingBooks = books.Where(b => b.Title.ToLower().Contains(title.ToLower())).ToList();
           if(matchingBooks.Any())
            {
                Console.WriteLine($"Found {matchingBooks.Count}");
                foreach(var book in matchingBooks)
                {
                    Console.WriteLine($"Title {book.Title}\nAuthor: {book.Author}\nISBN: {book.Isbn}\nNumber of page: {book.NumberOfPages}");
                }
            }
           else
                Console.WriteLine("No book was found in this search!😒");
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
