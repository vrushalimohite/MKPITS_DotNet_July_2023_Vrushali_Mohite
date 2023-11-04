using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace constructer_copy
{
    class Book
    {
        int bookid;
        string title;

        public Book()
        {
            bookid = 123;
            title="Digital Electronics";

        }
        public Book (Book b2)
        {
            bookid = b2.bookid;
            title = b2.title;


        }
        public void display()
        {
            Console.WriteLine("Book ID :" + bookid);
            Console.WriteLine("Book title :" + title);
        }
    }
    class program
    {
        static void Main()
        {
            Book book1 = new Book();
            Book book2 = new Book();
            Console.WriteLine("Book 1 details");
            book1.display();
            Console.WriteLine("Book 2 details ");
            book2.display();
            Console.ReadKey();

        }
    }
   
    }

