using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_employee_details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.getdata(123, "mayuri", "maneger", 50000);
            emp.displaydata();
            Console.ReadKey();
        }
        class Employee
        {
            int empno;
            string emp_name;
            string designation;
            int emp_salary;
            public void getdata(int no,string name,string desig,int sal)
            {
                empno = no;
                emp_name = name;
                designation = desig;
                emp_salary = sal;
            }
            public void displaydata()
            {
                Console.WriteLine("Employee no :" + empno);
                Console.WriteLine("Employee name :" + emp_name);
                Console.WriteLine("Employee Designation :" + empno);
                Console.WriteLine("Employee salary :" + emp_salary);
                


            }
        }
    }
}
