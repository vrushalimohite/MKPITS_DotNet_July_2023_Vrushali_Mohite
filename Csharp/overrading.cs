using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overradding
{
    public class Animal
    {
        public  virtual void  eat()
        {
            Console.WriteLine("Eating");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Dog is eatting");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Dog();
            a.eat();
            Console.ReadKey();
        }
    }
}
