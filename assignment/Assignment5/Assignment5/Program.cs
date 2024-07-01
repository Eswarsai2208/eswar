using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    public class Books
    {
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public Books(string bookName, string authorName)
        {
            BookName = bookName;
            AuthorName = authorName;
        }
        public void Display()
        {
            Console.WriteLine("Book Name: "+BookName+", Author: "+AuthorName);
            Console.ReadLine();
        }
    }
    public class BookShelf
    {
        private Books[] booksArray;
        public BookShelf()
        {
            booksArray = new Books[5];
        }
        public Books this[int index]
        {
            get
            {
                if (index < 0 || index >= booksArray.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range for BookShelf");
                }

                return booksArray[index];
            }
            set
            {
                if (index < 0 || index >= booksArray.Length)
                {
                    throw new IndexOutOfRangeException("Index is out of range for BookShelf");
                }
                booksArray[index] = value;
            }
        }
        public void DisplayBooks()
        {
            Console.WriteLine("Books on the BookShelf:");
            for (int i = 0; i < booksArray.Length; i++)
            {
                Console.Write("Book {i + 1}: ");
                if (booksArray[i] != null)
                {
                    booksArray[i].Display();
                }
                else
                {
                    Console.WriteLine("No book assigned");
                }
            }
        }
    }
    class Program
    {
        static void Main()
        {
            BookShelf shelf = new BookShelf();
            shelf[0] = new Books("Book1", "Author1");
            shelf[1] = new Books("Book2", "Author2");
            shelf[2] = new Books("Book3", "Author3");
            shelf[3] = new Books("Book4", "Author4");
            shelf[4] = new Books("Book5", "Author5");
            shelf.DisplayBooks();
        }
    }

}
