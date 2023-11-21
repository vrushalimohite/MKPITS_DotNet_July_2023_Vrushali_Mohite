using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_class_method
{
    class Company
    {
        public string name = "HCl";
        public void display()
        {
            Console.WriteLine("Company name is :" + name);
        }
    }
    class Employee : Company
    {
        public string name = "Rajesh";
        public void display()
        {
            base.display();
            Console.WriteLine(" Employee name is :" + name);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.display();
            Console.ReadKey();
        }
    }
}
