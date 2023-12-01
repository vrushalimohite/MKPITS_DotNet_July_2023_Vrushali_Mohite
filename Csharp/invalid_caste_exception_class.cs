using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invalidcastexception_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Ramesh");
            sb.Append("Rajesh");
            Console.WriteLine(sb.ToString());
            object obj = sb;
            Console.WriteLine("object is :" + obj);
            System.IO.StreamReader sr = (System.IO.StreamReader)obj; //error
            Console.WriteLine(sr);
            Console.ReadKey();
        }
    }
}
