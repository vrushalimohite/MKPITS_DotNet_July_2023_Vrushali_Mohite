

/*calling another method from one method*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Book
    {
        int bookid;
        String title, author;
        int price;

        public void getdata()
        {
            bookid = 1;
            title = "Electronics";
            author = "Raghav";
            price = 200;

        }
        //method overloaded 
        public void getdata(int bookid)
        {
            this.bookid = bookid;
            getdata(bookid, "html");

        }
        public void getdata(int bookid, String title)
        {
            this.bookid = bookid;
            this.title = title;
            getdata(bookid, title, "amitabh");

        }
        public void getdata(int bookid, String title, String author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            getdata(bookid, title, author, 234);

        }
        public void getdata(int bookid, String title, String author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("book id = " + bookid);
            Console.WriteLine("book title = " + title);
            Console.WriteLine("book author= " + author);
            Console.WriteLine("price = " + price);



        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------book1 details ----------");

            Book b = new Book();
            b.getdata(899);
            b.display();


            Console.ReadLine();

        }
    }
}
