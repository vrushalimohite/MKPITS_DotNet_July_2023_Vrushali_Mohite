
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while_print_one_to_five
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            do
            {
                Console.WriteLine("num ={0}", num);
            }

            while (num <= 5);
            num++;

            Console.ReadKey();
        }
    }
}
