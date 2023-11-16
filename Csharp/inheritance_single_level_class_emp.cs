using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_single_level_class_emp
{
    class person
    {
        public string name;
        public string address;

    }
    class employee : person
    {
        public int salary;
        public int empno;
        public string designation;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee e = new employee();
            e.name = "Rajesh";
            e.address = "Delhi";
            e.salary = 5000;
            e.empno = 14;
            e.designation = "manager";
            Console.WriteLine("Employee name :" + e.name);
            Console.WriteLine("Employee Addsress:" + e.address);
            Console.WriteLine("Employee Salary :" + e.salary);
            Console.WriteLine("Employee Number:" + e.empno);
            Console.WriteLine("Employee Designation:" + e.designation);
            Console.ReadKey();

        }
    }
}
