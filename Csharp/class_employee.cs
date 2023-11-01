/*Employee Class: Define an Employee class with properties for Name, EmployeeID, and Salary. 
 * Create an array of Employee objects to represent a company's employees. 
 * Write a program to find and display the details of the employee with the highest salary.*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace class_employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] Employeedata = new Employee[2];
            Employeedata[0] = new Employee();
            Employeedata[1] = new Employee();
            string name = null;
            int empid = 0;
            int salary = 0;
            for(int i=0;i<2;i++)
            {
                Console.WriteLine("Enter Employee Name");
                name = (Console.ReadLine());
                Console.WriteLine("Enter Employee ID");
                empid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Salary");
                salary = Convert.ToInt32(Console.ReadLine());

                Employeedata[i].getdata(name, empid, salary);
            }
            for(int i=0;i<2;i++)
            {
                Employeedata[i].displaydata();
            }
            Console.ReadKey();
        }
        class Employee
        {
            string name;
            int empid;
            int salary;
            public void getdata(string name,int empid,int salary)
            {
                this.name = name;
                this.empid = empid;
                this.salary = salary;
            }
            public void displaydata()
            {
                Console.WriteLine(" Employee Name:" + name);
                Console.WriteLine(" Employee ID:" + empid);
                Console.WriteLine(" Employee salary:" + salary);



            }
        }
    }
}
