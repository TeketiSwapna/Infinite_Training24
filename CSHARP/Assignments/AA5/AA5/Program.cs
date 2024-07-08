using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AA5
{ 

        class Books
        {
        
        
            public string BookName { get; set; }
            public string AuthorName { get; set; }

            public Books(string bookName, string authorName)
            {
                BookName = bookName;
                AuthorName = authorName;
            }

           
            public void Display() // Method 
        {
                Console.WriteLine($"Book Name: {BookName}");
                Console.WriteLine($"Author: {AuthorName}");
                Console.WriteLine();
                Console.Read();
        }
        }

        class BookShelf
        {
            private Books[] books;

            public BookShelf()
            {
                books = new Books[5];
            }
            public Books this[int index]
            {
                get
                {
                    if (index < 0 || index >= books.Length)
                    {
                        throw new IndexOutOfRangeException($"Index {index} is out of range for BookShelf.");
                    }
                    return books[index];
                }
                set
                {
                    if (index < 0 || index >= books.Length)
                    {
                        throw new IndexOutOfRangeException($"Index {index} is out of range for BookShelf.");
                    }
                    books[index] = value;
                }
            }

            public void DisplayBooks()
            {
                Console.WriteLine("Books in the Bookshelf:");
                Console.WriteLine("-----------------------");
                foreach (var book in books)
                {
                    if (book != null)
                    {
                        book.Display();
                    }
                }
            }
        }

       class Program
        {
            static void Main()
            {
                BookShelf shelf = new BookShelf();

                shelf[0] = new Books("The Magic of lost story", "Sudha Murthy");
                shelf[1] = new Books("That night ", "Nidhi Upadhyay");
                shelf[2] = new Books("Something I never told you", "Shravya Bhinder");
                shelf[3] = new Books("Grand Parents", "Sudha Murthy");
                shelf[4] = new Books("Tales of Shiva", "Swayam Ganguly");

                shelf.DisplayBooks();
            }
        }

    }

