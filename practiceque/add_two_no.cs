using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_add_two_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1,num2 = 0;
            Console.WriteLine("Enter two  Number");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine("Addition of two no:" + result);

            Console.ReadKey();
        }
    }
}
