using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace public_access_modifier
{
    class students
    {
        public int rollno = 14;
        public string name = "Rajesh";
        public void data(int num,string na)
        {
            Console.WriteLine("Roll no :" + num);
            Console.WriteLine("Name :" + na);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            students s = new students();
            Console.WriteLine("Roll no :" + s.rollno);
            Console.WriteLine("Name :" + s.name);
            s.data(15, "Ravi");
            Console.ReadKey();

        }
    }
}
