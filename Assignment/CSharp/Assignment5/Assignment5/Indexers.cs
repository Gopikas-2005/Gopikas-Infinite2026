using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    class Books
    {
        public string BookName;
        public string AuthorName;
        public Books(string bookname, string authorname)
        {
            BookName = bookname;
            AuthorName = authorname;
        }
        public void Display()
        {
            Console.WriteLine($"The Book is Written {BookName} by the Author {AuthorName}");
        }

    }
    class  BookShelves
        {
            Books[] books = new Books[5];
            public Books this[int index]
            {
                get {  return books[index];}
                set { books[index] = value; }
            }
            
        }
    class AddBooks
    {
        static void Main()
        {
            BookShelves BS = new BookShelves();
            BS[0] = new Books("Ramyanam","Valmigi");
            BS[1] = new Books("Brave New World", "Aldous Huxley");
            BS[2] = new Books("1984", "George Orwell");
            BS[3] = new Books("The Great Gatsby", "F. Scott Fitzgerald");
            BS[4] = new Books("Harry Potter and the Sorcerer’s Stone", "J.K. Rowling");
            for (int i = 0; i < 5; i++)
            {
                BS[i].Display();
            }
        }
    }

    }
