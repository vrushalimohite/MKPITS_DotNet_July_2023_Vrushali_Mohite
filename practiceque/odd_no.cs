using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p_odd_num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            if(num%2==1)
            {

                Console.WriteLine("odd number");
            }
            else
            {
                Console.WriteLine("Even number");
            }
            Console.ReadKey();
        }
    }
}
