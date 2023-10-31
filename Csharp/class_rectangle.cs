/*Rectangle Class: Create a Rectangle class with properties for Width and Height. Implement
a method within the class to calculate the area of the rectangle. Instantiate the Rectangle class and
compute the area for a rectangle with a width of 5 units and a height of 10 units.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            rec.getdata(5, 10);
            rec.displaydata();
            Console.ReadKey();
        }
        class Rectangle
        {
            int height;
            int width;
            int area;
            public void getdata(int h, int w)
            {
                height = h;
                width = w;
            }
            public void displaydata()
            {
                area = height * width;
                Console.WriteLine("Area of a Rectangle :" + area);
            }  
        }
    }
}
