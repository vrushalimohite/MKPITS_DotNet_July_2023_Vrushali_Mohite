/*Define an interface IDrawable with a method Draw() for drawing shapes.
Create a class Circle implementing IDrawable and demonstrate how a class that implements IDrawable can also implement other interfaces*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_que_4
{
    interface IDrawable
    {
         void Draw();
    }
    class circle: IDrawable
    {
        public void Draw()
        {
            Console.WriteLine("draw circle");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            circle c = new circle();
            c.Draw();
            Console.ReadKey();

        }
    }
}
