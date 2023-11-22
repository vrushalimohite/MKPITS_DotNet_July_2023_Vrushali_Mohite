using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    public class Hello
    {
        public void sayHello()
        {
            Console.WriteLine("call from first namespace");
        }
    }
}
        namespace secound
    {
        public class Hello
        {
            public void sayHello()
            {
                Console.WriteLine("call from secound namespace");

            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            first.Hello s = new first.Hello();
            secound.Hello s1 = new secound.Hello();
            s.sayHello();
            s1.sayHello();
            Console.ReadKey();
        }
    }

