using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_ex
{
    class person
    {
        public string name;
    }
    class students : person
    {
        public int rollno;
    }
    sealed class parttimestudents : students
    {
        public int hrs;
    }
     //class newstudents:parttimestudents        error becacuse parttimestudents is sealed

    internal class Program
    {
        static void Main(string[] args)
        {
            parttimestudents p = new parttimestudents();
            p.name = "Rajesh";
            p.hrs = 10;
            p.rollno = 24;
            Console.WriteLine("Name :" + p.name);
            Console.WriteLine("Roll no : :" + p.rollno);
            Console.WriteLine("No of hrs:" + p.hrs);
            Console.ReadKey();



        }
    }
}
