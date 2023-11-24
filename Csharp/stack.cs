using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push('h');

            s.Push('s');
            s.Push('u');
            s.Push('r');
            s.Push('v');
            foreach(char c in s)
            {
                Console.WriteLine(c + " ");
            }
            s.Push('m');
            s.Push('c');
            Console.WriteLine("Add chracter");
            Console.WriteLine( "Current stack ");
            foreach(char c in s)
            {
                Console.WriteLine(c + " ");
            }
            s.Pop();
            s.Pop();
            Console.WriteLine("Current stack ");
            foreach (char c in s)
            {
                Console.WriteLine(c + " ");
            }



            Console.ReadKey();

        }
    }
}
