using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class person //base class
    {
        public string name;
    }
    class students : person //derived class
    {
        public int rollno;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            students s = new students();
            s.name = "mayuri";
            s.rollno = 09;
            Console.WriteLine("Name :" + s.name);
            Console.WriteLine("Rool no :" + s.rollno);
            Console.ReadKey();
        }
    }
}
