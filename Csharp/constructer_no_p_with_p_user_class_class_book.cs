using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace constructor_no_p_with_p_user_class_bbok
{
    class Book
    {
        int bookid;
        string title, author;
        int price;
        public Book()
        {
            bookid = 123;
            title = "Digital Electrinics";
            author = "Kc Raman";
            price = 500;
            
        }
        public Book(int bookid, string title, string author, int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;

        }
        public void display()
        {
            Console.WriteLine("Book ID :" + bookid);
            Console.WriteLine("Book Title :" + title);
            Console.WriteLine("Book Author Name :" + author);
            Console.WriteLine("Book Price:" + price);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" ");

            Console.WriteLine("Book 1 Detailes With no parameter :");

            Console.WriteLine(" ");

            Book b = new Book();
            b.display();

            Console.WriteLine(" ");



            Console.WriteLine("Book 2 Detaile With  parameter :");

            Console.WriteLine(" ");

            Book b1 = new Book(223, "DCE", "Radhi krishna", 400);
            b1.display();
            Console.WriteLine(" ");

            Console.WriteLine("Enter Book ID Number");
            int i1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book Title");
            string t1 = (Console.ReadLine());

            Console.WriteLine("Enter Book Author Name");

            Console.WriteLine(" ");

            string a1 = (Console.ReadLine());


            Console.WriteLine("Enter Book Price");
            int p1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" ");
            Console.WriteLine("Book 3 Detaile With user information :");
            Book b2 = new Book(i1, t1, a1, p1);
            b2.display();
            Console.ReadKey();

        }
    }
}
