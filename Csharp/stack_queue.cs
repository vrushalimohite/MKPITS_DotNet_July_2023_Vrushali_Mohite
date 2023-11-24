/*create a stack  collection of employee class(empno,empname
 * , salary and designation)*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace stack_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(123);
            q.Enqueue("Rajesh");
            q.Enqueue(500000);
            q.Enqueue("maneger");
            foreach(object ob in q)
            {
                Console.WriteLine(ob);
            }
            Console.ReadKey();
        }
    }
}
