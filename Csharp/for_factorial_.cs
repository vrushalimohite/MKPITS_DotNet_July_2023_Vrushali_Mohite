using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop_factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fact = 1;
            int num;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());

            for(int flag=num;flag>0;flag--)
            {
                fact = fact * flag;
            }
            Console.WriteLine("Factorial :"+fact);

            Console.ReadKey();
        }
    }
}
