using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_abstract_class_shape_circle
{
    interface drawable
    {
        void draw();
    }
    class rectangle : drawable
    {
        public void draw()
        {
            Console.WriteLine(" rectangle drawable");
        }
    }
    class circle : drawable
    {
        public void draw()
        {
            Console.WriteLine(" circle drawable");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            drawable s = new rectangle();
            s.draw();
            s = new circle();
            s.draw();
            Console.ReadKey();
        }
    }
}
