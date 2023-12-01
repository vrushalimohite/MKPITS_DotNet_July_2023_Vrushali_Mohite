using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexoutofrangeexception_error
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 4 };
            Console.WriteLine(arr[4]);
            Console.ReadKey();
        }
    }
}
