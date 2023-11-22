using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_students
{
    class students
    {
        public string name { get; set; }
        public int rollno { get; set; }
        public string address { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            students s = new students();
            s.name = "Raj";
            s.rollno = 14;
            s.address = "Nagpur";
            Console.WriteLine("Students Name :" + s.name);
            Console.WriteLine("Students Roll no :" + s.rollno);
            Console.WriteLine("Students Address :" + s.address);
            Console.ReadKey();

        }
    }
}
