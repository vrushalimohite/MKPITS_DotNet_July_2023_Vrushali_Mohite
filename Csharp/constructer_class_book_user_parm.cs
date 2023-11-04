using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructer_class_book_user_parm
{
    class Book
    {
        int bookid;
        string title;
        string author;
        int price;
        public Book(int bookid,string title,string author,int price)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("Bookid :"+bookid);
            Console.WriteLine("Book title :"+title);
            Console.WriteLine("Book Author :"+author);
            Console.WriteLine("Book price :"+price);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Book ID ");
             int b1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Book Title ");
           string  t1=(Console.ReadLine());
            Console.WriteLine("Enter Book Author");
           string a1 = (Console.ReadLine());

            Console.WriteLine("Enter Book Price ");
           int p1 = Convert.ToInt32(Console.ReadLine());

            Book b = new Book(b1,t1,a1,p1);//this will call parameterized constructor
            b.display();
            Console.ReadKey();

        }
    }
}
