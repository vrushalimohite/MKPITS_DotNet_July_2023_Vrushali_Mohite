using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_base_class_employee
{
    class employee
    {
        public int salary = 500000;
    }
    class programmer : employee
    {
        public int bonus = 100;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            programmer p = new programmer();
            Console.WriteLine("Salary :" + p.salary);
            Console.WriteLine("Bonus :" + p.bonus);
            Console.ReadKey();
        }
    }
}
