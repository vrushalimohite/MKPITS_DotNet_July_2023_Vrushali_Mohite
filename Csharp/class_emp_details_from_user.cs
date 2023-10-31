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
            Console.WriteLine("Enter emp code" + ", " + "Employee name" + " ," + "Employee Designation" + " ," + "Employee salary");
            int emp_code = Convert.ToInt32(Console.ReadLine());
            string emp_name = Convert.ToString(Console.ReadLine());
            string emp_designation = Convert.ToString(Console.ReadLine());
            int emp_salary = Convert.ToInt32(Console.ReadLine());


            emp.getdata(emp_code,emp_name,emp_designation,emp_salary);
            emp.displaydata();
            Console.ReadKey();
        }
        class Employee
        {
            int empno;
            string emp_name;
            string designation;
            int emp_salary;
            public void getdata(int empno, string emp_name, string designation, int emp_salary)
            {
               this. empno = empno;
               this. emp_name =emp_name;
               this. designation = designation;
               this. emp_salary = emp_salary;
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
