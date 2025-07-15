using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace LibraryManagement
{
    public class Library
    {
        public List<Book> books = new List<Book> ();
        
          
        

        /* To be implemented by Clovis le pro */
        //public void AddBook(Book book) { ... }
        //public void ViewBooks() { ... }
        //public void SearchBookByTitle(string title) { ... }
        //public void SearchBookById(string id) { .. }




        public void AddBook()
        {
            Console.Write("Enter book Id: ");
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
            Console.WriteLine("Book Successfully added!");
        }

        public void ViewBooks()
        {
            Console.WriteLine("\n******************LIST OF BOOKS IN LIBRARY*****************\n");
            foreach (var book in books)
            {
            if(book == null)
             {

                Console.WriteLine("There is no book present in this library!");
                    return;
             }

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
                    Console.WriteLine("\n");
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
        { 
            var book = books.FirstOrDefault(b => b.Id == id);
            if(book is null)
            {
                Console.WriteLine("Book is not found");
                return;
            }
            else if(!book.IsAvailable)
            {
                Console.WriteLine("Book has been borrowed");
                return;
            }
            book.IsAvailable = false;
            Console.WriteLine("Book has been successfully borrowed!");
        }
        public void ReturnBook(int id)
        { 
            var returnedBook = books.FirstOrDefault(b => b.Id == id);
            if(returnedBook is null)
            {
                Console.WriteLine("This is not found!");
                return;
            }
            else if(returnedBook.IsAvailable)
            {
                Console.WriteLine("Book was not borrowed!");
                return;
            }
            returnedBook.IsAvailable = true;
            Console.WriteLine("Book has been returned successfully!!");
        }
        public void DisplayMenu()
        {
            while(true)
            {

                Console.WriteLine("\n**************LIBRARY MENU***********");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("1.\t|   Display books       \t\t|");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("2.\t|   Add a book            \t\t|");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("3.\t|   Search book by Id     \t\t|");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("4.\t|   Search by title       \t\t|");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("5.\t|   Borrow book           \t\t|");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("6.\t|   Return book           \t\t|");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("7.\t|   Remove book           \t\t|");
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("8.\t|   Exit                  \t\t|");
                Console.WriteLine("-------------------------------------------------");

                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        ViewBooks();
                        break;
                    case 2:
                        AddBook(); 
                        break;
                    case 3:
                        Console.Write("Enter book Id: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        SearchBookById(id);
                        break;
                    case 4:
                        Console.Write("Enter book title: ");
                        string title = Console.ReadLine();
                        SearchBookByTitle(title);
                        break;
                    case 5:
                        Console.Write("Enter the id of book to borrow: ");
                        int borrowId = Convert.ToInt32(Console.ReadLine());
                        BorrowBook(borrowId);
                        break;
                    case 6:
                        Console.Write("Enter the Id of the book to return: ");
                        int returnId = Convert.ToInt32(Console.ReadLine());
                        ReturnBook(returnId);
                        break;
                    case 7:
                        Console.Write("Enter the Id of the book to remove: ");
                        int removeId = Convert.ToInt32(Console.ReadLine());
                        RemoveBook(removeId);
                        break;
                    case 8:
                        return;
                    default:
                        Console.WriteLine("Invalid Option!!");
                        break;

                }
            }

        }


    }
}
