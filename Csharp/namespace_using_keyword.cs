using first.second;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    public class hello
    {
        public void sayhello()
        {
            Console.WriteLine("call from first namespace");
        }
    }

    namespace second
    {
        public class welcome
        {
            public void sayhello()
            {
                Console.WriteLine("call from secound namespace");

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            hello h1 = new hello();
            welcome w1 = new welcome();
            h1.sayhello();
            w1.sayhello();
            Console.ReadKey();
        }
    }
}

