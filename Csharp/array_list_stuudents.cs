using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace array_list_students
{
    class students
    {
        public int rn;
        public string name;
        public students (int rn,string name)
        {
            this.rn = rn;
            this.name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            students s1 = new students(12, "Amit");
            students s2 = new students(34, "Rajesh");
            ArrayList al = new ArrayList();
            al.Add(s1);
            al.Add(s2);
            foreach(students s in al)
            {
                Console.WriteLine("Roll No :" + s.rn);
                Console.WriteLine("Name :" + s.name);


            }
            Console.ReadKey();
        }
    }
}
