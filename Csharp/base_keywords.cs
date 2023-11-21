using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace base_keywords
{
    class Animal
    {
        public string colour = "white";
    }
    class Dog : Animal
    {
        public string colour = "red";
        public void displaycolour()
        {
            Console.WriteLine("Dog colour is :" + colour);
            Console.WriteLine("Animal colour is :" + base.colour);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.displaycolour();
            Console.ReadKey();
        }
    }
}
