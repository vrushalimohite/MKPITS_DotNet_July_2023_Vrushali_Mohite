using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sealed_method
{
    class person
    {
        public virtual void display()
        {
            Console.WriteLine("hello from person class");
        }
     
    }
    class students : person
    {
        public string name;
        public sealed override void display()
        {
            Console.WriteLine("hello from students class");

        }
    }
    class newstudents : students
    {
       // public override void display()   error due to students override is sealed
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            newstudents n = new newstudents();
            n.display();
            Console.ReadKey();
        }
    }
}
