using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor_class_book_np_p_with_four_p
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;
        public Book()
        {
            Console.WriteLine("Constructor with no Parameter :");
            Console.WriteLine("---------------------------------");
            bookid = 123;
            title = "Dce";
            author = "Ram";
            price = 300;

        }
        public Book(int bookid, string title, string author, int price)
        {
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Constructer with parameter :");
            this.bookid=bookid;
            this.title=title;
            this.author=author;
            this.price=price;
        }
        public void display()
        {
            Console.WriteLine("Book ID :"+bookid);
            Console.WriteLine("Book Title :"+title);
            Console.WriteLine("Book Author :"+author);
            Console.WriteLine("Book price :"+price);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.display();
            Book b1 = new Book(123,"ECE","Sham",600);
            b1.display();
            Console.ReadKey();
        }
    }
}
