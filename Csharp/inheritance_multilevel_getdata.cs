
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inhiritance_multilevel_getdata
{
    public class person
    {
        string name;
        string address;
        public void getpersondata(string name,string address)
        {
            this.name = name;
            this.address = address;
        }
        public void displaypersondata()
        {
            Console.WriteLine("Name :"+name);
            Console.WriteLine("Address :"+address);

        }
    }
    public class employee : person
    {
        int empno;
        int salary;
        public void getemployeedata(int empno,int salary)
        {
            this.empno = empno;
            this.salary = salary;
        }
        public void displayemployeedata()
        {
            Console.WriteLine("Employee no :"+empno);
            Console.WriteLine("Employee Salary :"+salary);


        }
    }
    public class parttimeemp : employee
    {
        int hrs;
        public void getparttimeempdata(int hrs)
        {
            this.hrs = hrs;
        }
        public void displayparttimeempdata()
        {
            Console.WriteLine("No of Hrs :"+hrs);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            parttimeemp e = new parttimeemp();
            e.getpersondata("Rajesh", "Nagpur");
            e.getemployeedata(14, 5000);
            e.getparttimeempdata(5);
            e.displaypersondata();
            e.displayemployeedata();
          e.displayparttimeempdata();
            Console.ReadKey();
        }
    }
}
