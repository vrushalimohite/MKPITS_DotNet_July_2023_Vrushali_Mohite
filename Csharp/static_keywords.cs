using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_keywods_ex
{
    class Book
    {
        public static int bookid;
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Book.bookid = 123;
            Console.WriteLine("Book id =" + Book.bookid);
            Console.ReadKey();


        }
    }
}
