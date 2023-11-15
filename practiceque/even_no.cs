using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_even_no
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            if(num%2!=1)
            {
                Console.WriteLine("Even number");

            }
            else
            {
                Console.WriteLine("odd number");
            }
            Console.ReadKey();
        }
    }
}
