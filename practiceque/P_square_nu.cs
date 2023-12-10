using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_square_of_nums
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int num = 0;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());
            int square = num * num;
            Console.WriteLine("Square=" + square);
            Console.ReadLine();
        }
    }
}
