using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace clculator_properties_mtd
{
    public class calculator
    {
        public int Result { get; private set; }
        public void Add(int num)
        {
            Result += num;
        }
        public void Sub(int num)
        {
            Result -= num;
        }
        public void Mul(int num)
        {
            Result *= num;
        }
        public void div(int num)
        {
            if (num != 0)
            {
                Result /= num;
            }
            else
            {
                Console.WriteLine("Zero can not divide by num");
            }
        }
        public void clear()
        {
            Result = 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                calculator c = new calculator();
                c.Add(5);
                Console.WriteLine("Result(Add) :" + c.Result);
                c.Mul(3);
                Console.WriteLine("Result(Mul) :" + c.Result);

                c.div(8);
                Console.WriteLine("Result(Div) :" + c.Result);

                c.Sub(6);
                Console.WriteLine("Result(Sub) :" + c.Result);

                c.clear();
            Console.ReadKey();
        }
    }
}
