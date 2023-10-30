using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_each_print_hello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[]  arr = { 'H', 'e', 'l', 'l', 'o' };
            foreach(char ch in arr)
            {
                Console.WriteLine(ch);
            }
            Console.ReadKey();
        }
    }
}
