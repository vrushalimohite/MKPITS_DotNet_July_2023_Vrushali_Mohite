using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace mtd_overloading_example
{
    class calculate

    {
        public void addition(int n1,int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("Addition of two int nos :" + res);
        }
        public void addition(float n1,float n2)
        {
            float res = n1 + n2;
            Console.WriteLine("Addition of two float nos :" + res);


        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            calculate c = new calculate();
            Console.WriteLine("Now call int varibles");

            c.addition(2, 8);
            Console.WriteLine("Now call float varibles");
            c.addition(3.1f, 5.4f);
            Console.ReadKey();
        }
    }
}
