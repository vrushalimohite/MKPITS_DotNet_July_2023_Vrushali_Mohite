/*create a class book ,overload  method with 0 ,1 ,2,3,4 parameters.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace mtd_overloading_0ne_four_parm
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;

        public void getdata(int bookid)
        {
            this.bookid = bookid;

        }
        public void getdata(int bookid,string title)
        {
            this.bookid = bookid;
            this.title = title;
        }
        public void getdata(int bookid, string title,string author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;

        }
        public void getdata(int bookid, string title, string author,int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Bookid :" + bookid);
            Console.WriteLine("Book Title :" + title);
            Console.WriteLine("Book Author :" +author);
            Console.WriteLine("Book price :" + price);

        }



    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            Console.WriteLine(" ");
            Console.WriteLine("----Book 1 details--- ");

            b.getdata(123);
            b.display();
            Console.WriteLine(" ");
            Console.WriteLine("----Book 2 details--- ");
            Book b1 = new Book();
            b1.getdata(123, "csharp");
            b1.display();
            Console.WriteLine(" ");
            Console.WriteLine("----Book 3 details--- ");
            Book b2 = new Book();
            b2.getdata(123, "charp", "C vRaman");
            b2.display();
            Console.WriteLine(" ");
            Console.WriteLine("----Book 4 details--- ");
            Book b3 = new Book();
            b3.getdata(1254, "javascript", "ram", 460);
            b3.display();
            Console.ReadKey();
        }
    }
}
