using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_len_breadth_area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int len;
            int breadth;
            Console.WriteLine("Enter length And breadth");
            len = Convert.ToInt32(Console.ReadLine());
            breadth = Convert.ToInt32(Console.ReadLine());
            int area = len * breadth;
            Console.WriteLine("Area :" + area);
            Console.ReadLine();

        }
    }
}
