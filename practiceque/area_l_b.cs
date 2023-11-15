using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_area_l_b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length;
            int breadth;
            Console.WriteLine("Enter Length");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter breadth");
            breadth= Convert.ToInt32(Console.ReadLine());
            int area = length * breadth;
            Console.WriteLine("Area =" + area);
            Console.ReadKey();


        }
    }
}
