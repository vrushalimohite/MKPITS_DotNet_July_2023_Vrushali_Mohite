using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_class_constructor
{
    class company
    {
        public string name = "TCS";
        public company()
        {
            Console.WriteLine("Based class constructor");
            Console.WriteLine("Company name :" + name);
        }
    }
    class employee : company
    {
        public string name = "Rajesh";
        public employee()
        {
            Console.WriteLine("Derived class constructor");
            Console.WriteLine("Emnployee name :" + name);


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee e = new employee();
            Console.ReadKey();
        }
    }
}
