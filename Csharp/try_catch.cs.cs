using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;
            Console.WriteLine("Enter two Number");
            num = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            try
            {
                res = num / n;
            }
            catch
            {
                Console.WriteLine("cannot divide by zero");
            }
            Console.WriteLine("Result :" + res);
            Console.ReadLine();

        }
    }
}
