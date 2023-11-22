using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp16
{
    class student
    {
        protected string name;
        public void getdata()
        {
            name = "ravi";
            Console.WriteLine("name " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            //s.name = "ravi";
            s.getdata();
            Console.ReadKey();
        }
    }
}
