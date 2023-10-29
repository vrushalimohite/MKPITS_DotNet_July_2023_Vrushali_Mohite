using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atleast_one_condition_true
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 22;
            do
            {
                Console.WriteLine("num -{0}", num);
                num++;
            }
            while (num <= 21);
            Console.WriteLine("Bye");
            Console.ReadKey();
        }
    }
}
