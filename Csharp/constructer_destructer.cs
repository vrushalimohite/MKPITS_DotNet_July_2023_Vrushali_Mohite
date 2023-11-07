using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructer_destructer
{
    class Employee
    {
        public Employee()
        {
            Console.WriteLine("Constructer Called");
        }
        ~Employee()
        {
            Console.WriteLine("Destructer Called");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Console.ReadKey();
            Employee e1 = new Employee();
            Console.ReadKey();
        }
    }
}
