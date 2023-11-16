using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_single_level_class_students
{
    class person
    {
       public string name;
         public string address;

    }
    class students : person
    {
       public int rollno;
       public  int marks;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            students s = new students();
            s.name = "raj";
            s.address = "nagpur";
            s.rollno = 24;
            s.marks = 55;
            Console.WriteLine("Name :" + s.name);
            Console.WriteLine("Address :" + s.address);
            Console.WriteLine("Roll no :" + s.rollno);
            Console.WriteLine("Marks:" + s.marks);
            Console.ReadKey();


        }
    }
}
