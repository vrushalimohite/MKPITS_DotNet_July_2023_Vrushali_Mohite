using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_single_level_protected
{
    class employee

    {
        protected int salary;
    }
    class programmer : employee
    {
        int bonus;
        public void getdata(int salary,int bonus)
        {
            this.salary = salary;
            this.bonus = bonus;
        }
        public void displaydata()
        {
            Console.WriteLine("Salary :" + salary);
            Console.WriteLine("Bonus :" + bonus);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            programmer p = new programmer();
            p.getdata(5000, 800);
            p.displaydata();
            Console.ReadKey();
        }
    }
}
