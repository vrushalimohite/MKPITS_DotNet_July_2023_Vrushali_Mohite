using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_hierchikal
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
    class employee : person
    {
       public  int salary;
       public string designation;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            students s = new students();
           
            s.name = "amit";
            s.address = "nagpur";
            s.rollno = 44;
            s.marks = 999;
            Console.WriteLine("-----------Students details-----------");
            Console.WriteLine("Name :" + s.name);
            Console.WriteLine("address : " + s.address);
            Console.WriteLine("rno :" + s.rollno);
            Console.WriteLine("marks :" + s.marks);
            employee emp = new employee();
            emp.name = "ravinesh";
            emp.address = "mumbai";
            emp.salary = 55544;
            emp.designation = "manager";
            Console.WriteLine("--------------- emp details ----------");
            Console.WriteLine("name : " + emp.name);
            Console.WriteLine("address : " + emp.address);
            Console.WriteLine("salary :" + emp.salary);
            Console.WriteLine("designation :" + emp.designation);
            Console.ReadKey();



        }
    }
}
