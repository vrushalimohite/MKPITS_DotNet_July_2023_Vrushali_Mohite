using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace array_list_count_capacity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(14);
            ar.Add(22);
            ar.Add(25);
            foreach(object ob in ar)
            {
                Console.WriteLine("Roll No :" + ob);
            }
            Console.WriteLine("Capacity :" + ar.Capacity);
            Console.WriteLine("Count :" + ar.Count);
            Console.ReadKey();
        }
    }
}
