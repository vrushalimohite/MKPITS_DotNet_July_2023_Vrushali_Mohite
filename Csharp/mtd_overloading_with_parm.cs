/*create a class book having member variables bookid , title, author, and price 
and a method getdata() with no parameters , create another overloaded method getdata() with 4 parameters
and method display
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtd_overloading_with_parm
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;
        public void getdata()
        {
            bookid = 456;
            title = "dce";
            author = "v c raman";
            price = 450;
        }
        public void getdata(int bookid,string title,string author,int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Book id :" + bookid);
            Console.WriteLine("Book title:" + title);
            Console.WriteLine("Book Author :" + author);
            Console.WriteLine("Book price :" + price);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.getdata(456, "english", "ratan", 540);
            b1.display();
            Console.WriteLine("enter Bookid");
            int bookid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter Title Name");
            string title=(Console.ReadLine());
            Console.WriteLine(" Enter Author name");
            string author= (Console.ReadLine());
            Console.WriteLine("Enter Book Price");
            int price= Convert.ToInt32(Console.ReadLine());
            Book b2 = new Book();
            b2.getdata(bookid, title, author, price);
            b2.display();
            Console.ReadKey();
        }
    }
}
