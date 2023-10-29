using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_print_table_mtd_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sn = 1, en = 2;
            int result1, result2;
            int counter = 1;
            while(counter<=10)
            {
                result1 = sn * counter;
                result2 = en * counter;

                Console.WriteLine("{0}*{1}={2}", sn, counter, result1);
                Console.WriteLine("\t");
                Console.WriteLine("\t");



                Console.WriteLine("{0}*{1}={2}", en, counter, result2);

                counter++;
                Console.WriteLine();

            }
            Console.ReadKey();

        }
    }
}
