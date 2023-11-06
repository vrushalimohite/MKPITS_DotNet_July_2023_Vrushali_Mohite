/*create a class student having fields rno,name,course,fees
create a method getdata with no parameters , create overloaded method with 2 parameters, 3 parameters, 4 parameters and display method.
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtd_overloading_class_students
{
    class Students
    {
        int rollno;
        string name;
        string course;
        int fees;
        public void getdata(int rollno)
        {
            this.rollno = rollno;

        }
        public void getdata(int rollno,string name)
        {
            this.rollno = rollno;
            this.name = name;

        }
        public void getdata(int rollno,string name,string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;

        }
        public void getdata(int rollno, string name, string course,int fees)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
            this.fees = fees;

        }
        public void display()
        {
            Console.WriteLine("Students Roll no :" + rollno);
            Console.WriteLine("Students Name :" + name);
            Console.WriteLine("Students Course:" + course);
            Console.WriteLine("Students fees:" + fees);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");

            Console.WriteLine("Students 1 details");
            Students stud = new Students();
            stud.getdata(11);
            stud.display();
            Console.WriteLine(" ");

            Console.WriteLine("Students 2 details");
            Students stud1 = new Students();
            stud1.getdata(11,"pratik");
            stud1.display();
            Console.WriteLine(" ");

            Console.WriteLine("Students 3 details");
            Students stud2= new Students();
            stud2.getdata(11, "pratik",".Net"); 
            stud2.display();

            Console.WriteLine(" ");
               Console.WriteLine("Students 4 details");
            Students stud3= new Students();
            stud3.getdata(11, "pratik","html",50000);

            stud3.display();


            Console.ReadKey();





        }
    }
}
