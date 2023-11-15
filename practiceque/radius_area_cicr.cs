using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_radius_area_circ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int radius;
            Console.WriteLine("Enter Radius");
            radius = Convert.ToInt32(Console.ReadLine());
            float area = 3.14f * radius * radius;
            Console.WriteLine("Area of circle =" + area);
            float cicr = 2 * 3.14f * radius;
            Console.WriteLine("Circumference is =" + cicr);
            Console.ReadKey();
        }
    }
}
