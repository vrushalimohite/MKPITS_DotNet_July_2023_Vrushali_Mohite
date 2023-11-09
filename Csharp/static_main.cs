using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_main
{
    class Book
    {
        public static int bookid;
        static void display()
        {
            Console.WriteLine("hello from static display method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book.bookid = 125;
            Program p = new Program();
            p.Main();
            Console.WriteLine("Book id=" +Book.bookid);
            Console.ReadKey();
        }
        void Main()
        {
            Console.WriteLine("hello from another main mtd");
           
        }
    }
}
