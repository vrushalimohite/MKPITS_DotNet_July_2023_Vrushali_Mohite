using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array_mtd_getlength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 21, 22, 23,55,22 };
            int l = arr.GetLength(0);
            Console.WriteLine(l);
            Console.ReadKey();
        }
    }
}
