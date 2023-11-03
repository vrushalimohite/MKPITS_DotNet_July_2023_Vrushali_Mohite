using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace constructor_class_book
{
    class Book
    {
        int bookid;
        string title, author;
        int price;

        public Book()
        {
            bookid = 123;
            title = "digital Electronics";
            author = "cv raman";
            price = 200;
        }
            public void display()
            {
            Console.WriteLine("Book id :" + bookid);
            Console.WriteLine(" Book Title :" + title);
            Console.WriteLine(" Book Author Name :" + author);
            Console.WriteLine(" Book price :" + price);
            }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.display();
            Console.ReadLine();

        }
    }
}
