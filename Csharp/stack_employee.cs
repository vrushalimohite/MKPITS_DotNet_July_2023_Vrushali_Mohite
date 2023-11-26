

/*create a stack  collection of employee class(empno,empname , salary and designation)*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace stack_employee
{
    class employee
    {
        public int empno;
        public string empname;
        public int salary;
        public string designation;
        public employee(int empno, string empname,int salary,string designation)
        {
            this.empno = empno;
            this.empname = empname;
            this.salary = salary;
            this.designation = designation;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee e1 = new employee(123, "Rajesh", 5000, "Maneger");
            employee e2 = new employee(2143, "Mahesh", 7000, "Developer");
            employee e3 = new employee(55123, "Ridhi", 88000, "Coder");
            employee e4 = new employee(564123, "Shivay", 15000, "Designer");

            Stack s = new Stack();
            s.Push(e1);
            s.Push(e2);
            s.Push(e3);
            s.Push(e4);
            foreach(employee  emp in s)
            {
                Console.WriteLine("Employee Number:" + emp.empno);
                Console.WriteLine("Employee Name :" + emp.empname);
                Console.WriteLine("Employee Salary :" + emp.salary);
                Console.WriteLine("Employee Designation :" + emp.designation);
                Console.WriteLine("------------------------------------------");


            }
            employee p = (employee)s.Pop();
            Console.WriteLine(p.empno+" "+p.empname+" "+p.salary+" "+p.designation);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(" ");


            Console.WriteLine("After Pop");
            Console.WriteLine(" ");

            foreach (employee emp in s)
            {
                Console.WriteLine("Employee no :"+emp.empno);
                Console.WriteLine("Employee Name :" + emp.empname);
                Console.WriteLine("Employee Salary :" + emp.salary);
                Console.WriteLine("Employee Designation :" + emp.designation);
                Console.WriteLine(" ");


            }

            Console.ReadKey();



        }
    }
}
