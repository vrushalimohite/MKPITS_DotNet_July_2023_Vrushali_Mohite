using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_square_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, result ;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
             result= num * num;
            Console.WriteLine("Square ="+result);
            Console.ReadKey();
        }
    }
}
