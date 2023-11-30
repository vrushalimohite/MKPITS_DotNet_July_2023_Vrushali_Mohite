using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_finally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int n;
            Console.WriteLine("Enter Two Numbers");
            num = Convert.ToInt32(Console.ReadLine());
            n = Convert.ToInt32(Console.ReadLine());
            int res = 0;
            try
            {
                res = num / n;
            }
            catch (Exception ee)
            {
                Console.WriteLine("catch block is executing");
                Console.WriteLine("cannot divide by zero ");

            }
            finally
            {
                Console.WriteLine("finally block is executing");
                Console.WriteLine("res = " + res);

            }

            Console.WriteLine("res = " + res);

            Console.ReadLine();
        }
    }
}
