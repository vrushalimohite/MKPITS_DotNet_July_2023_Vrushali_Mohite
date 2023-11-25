using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_single_level_inheritance
{
    class person
    {
        public int age;
        public string name;
    }
    class students : person
    {
        public int rollno;
        public int marks;
    }
    internal class Program
    {
        

        static void Main(string[] args)
        {
            students s = new students();
            s.age = 1;
            s.name = "vrushali";
            s.rollno = 22;
            s.marks = 50;
            Console.WriteLine("Name :" + s.name);
            Console.WriteLine("Age :" + s.age);
            Console.WriteLine("Roll no :" + s.rollno);
            Console.WriteLine("Marks :" + s.marks);
            Console.ReadKey();

        }
    }
}
