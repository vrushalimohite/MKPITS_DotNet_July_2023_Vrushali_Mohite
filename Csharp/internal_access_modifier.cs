using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace internal_access_modifier
{
    class students
    {
        internal int rollno;
        internal string name;
        public void displaydata()
        {
            Console.WriteLine("Roll no :" + rollno);
            Console.WriteLine("Name :" + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            students s = new students();
            s.rollno = 34;
            s.name = "Priya";
            s.displaydata();
            Console.ReadKey();
        }
    }
}
