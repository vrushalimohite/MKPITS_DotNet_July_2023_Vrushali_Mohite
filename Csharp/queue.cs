using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue('v');           
            q.Enqueue('r');
            q.Enqueue('u');
            q.Enqueue('s');

            q.Enqueue('h');
            Console.WriteLine(" Queue");
           foreach(char c in q)
            {
                Console.WriteLine(c+"\n");
            }
            q.Dequeue();
            Console.WriteLine(" DeQueue");

            foreach (char c in q)
            {
                Console.WriteLine(c + "\n");
            }

            Console.ReadKey();
        }
    }
}
