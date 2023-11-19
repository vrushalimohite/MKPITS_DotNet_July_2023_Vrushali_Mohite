using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_hierchical_inheritance
{
    class person
    {
        public int id;
        public int age;
    }
    class students : person
    {
        public int rollno;
        public string name;
    }
    class employee : person
    {
        public int salary;
        public int bonus;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            students s=new students();
            s.id = 12;
            s.age = 25;
            s.rollno = 35;
            s.name = "Ajit";
            Console.WriteLine("---Students details----");

            Console.WriteLine("ID :"+s.id);
            Console.WriteLine("Age:" + s.age);
            Console.WriteLine("Roll No :" + s.rollno);
            Console.WriteLine("name :" + s.name);
            employee e = new employee();
            e.id = 45698;
            e.age = 40;
            e.salary = 5000;
            e.bonus = 200;
            Console.WriteLine("---Employee details----");

            Console.WriteLine("ID :" + e.id);
            Console.WriteLine("Age :" + e.age);
            Console.WriteLine("Salary :" + e.salary);
            Console.WriteLine("Bonus :" + e.bonus);
            Console.ReadKey();



        }
    }
}
