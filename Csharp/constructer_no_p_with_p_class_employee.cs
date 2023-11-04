/*create a class employee having fields empno,empname , designation and salary
create a constructor with no parameters and create another parameterized constructor 
with 4 parameters*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructer_no_p_with_p_class_employee
{
    class Employee
    {
        int empno;
        string empname, designation;
        int salary;
        public Employee()
        {
            empno = 546;
            empname = "Rohit";
            designation = "Maneger";
            salary = 5000;

        }
        public Employee(int empno,string empname,string designation,int salary)
        {
            this.empno = empno;
            this.empname = empname;
            this.designation = designation;
            this.salary = salary;

        }
        public void display()
        {
            Console.WriteLine("Employee NO :"+empno);
            Console.WriteLine("Employee Name :"+empname);
            Console.WriteLine("Designation :"+designation);
            Console.WriteLine("Salary :"+salary);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Employee 1 details with No parameter");
            Console.WriteLine("");

            Employee emp = new Employee();
            emp.display();
            Console.WriteLine(" ");
            Console.WriteLine(" Employee 2 details with parameter");
            Console.WriteLine(" ");
            Employee e1 = new Employee(4565,"sayali","Engineer",5000000);
            e1.display();
            Console.ReadKey();

        }
    }
}
