using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constructer
{
    class Book
    {
        static string title;
        static Book()
        {
            Console.WriteLine("Static constructer");
            title = "mkpits";
        }
        public void display()
        {
            Console.WriteLine("title :" + title);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b1 = new Book();
            b1.display();
            Book b2 = new Book();
            b2.display();
            Book b3= new Book();
            b3.display();
            Console.ReadKey();
        }
    }
}
