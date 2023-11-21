using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_abstract_class_shape_circle
{
    interface shape
    {
        void draw();
    }
    class rectangle : shape
    {
        public void draw()
        {
            Console.WriteLine("Method from rectangle class");
        }
    }
    class circle : shape
    {
       public  void draw()
        {
            Console.WriteLine("Method from circle class");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            shape s = new rectangle();
            s.draw();
            s= new circle();
            s.draw();
            Console.ReadKey();
        }
    }
}
