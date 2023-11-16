using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_single_level_mtd_class_emp
{
    public class person
    {
        public string name;
        public string address;
        public void getpersondata(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displaypersondata()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("Address:" + address);

        }
    }
    public class employee : person
    {
        public int empno;
        public int salary;
        public void getemployeedata(int empno,int salary)
        {
            this.empno = empno;
            this.salary = salary;

        }
        public void displayemployeedata()
        {
            Console.WriteLine("Employee no :" + empno);
            Console.WriteLine("Employee Salary :" +salary);


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee e = new employee();
            e.getpersondata("Khan sir", "nagpur");
            e.displaypersondata();
            e.getemployeedata(12,50000);
            e.displayemployeedata();
            Console.ReadKey();
        }
    }
}
