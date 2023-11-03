using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructer_class_product
{
    class Employee
    {
        int employeeid;
        string employeename;
        string designation;
        int salary;



        public Employee()
        {
            employeeid = 123;
            employeename = "Rohit";
            designation= "Maneger";
            salary= 100000;

        }
        public void display()
        {
            Console.WriteLine("Employee ID :" + employeeid);
            Console.WriteLine("Employee Name :" + employeename);
            Console.WriteLine("Designation :" + designation);
            Console.WriteLine("Employee Salary :" + salary);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee p = new Employee();
            p.display();
            Console.ReadLine();
        }
    }
}
