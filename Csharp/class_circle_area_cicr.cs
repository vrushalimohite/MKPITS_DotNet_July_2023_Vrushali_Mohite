/*Circle Class: Create a Circle class with a property for Radius. Implement methods to 
 calculate the circumference and area of the circle. Instantiate the Circle class and 
compute both the circumference and area for a circle with a radius of 7 units.*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ciecle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle();
            Console.WriteLine("Enter radius");
            int rad = Convert.ToInt32(Console.ReadLine());
            cir.getdata(rad);
            cir.displaydata();
            Console.ReadKey();
        }
        class Circle
        {
            int rad;
            int area;
            float cicr;
            public void getdata(int rad)
            {
                this.rad = rad;
                this.area = area;
                this.cicr = cicr;
            }
            public void displaydata()
            {
              float  area = 3.14f * rad * rad;
                Console.WriteLine("area is:" + area);
                cicr = 2 * 3.14f * rad;
                Console.WriteLine("circumference is:" + cicr);


            }
        }
    }
}
