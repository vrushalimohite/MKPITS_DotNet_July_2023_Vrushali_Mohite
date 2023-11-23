using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace arrayList_insert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ra = new ArrayList();
            ra.Add(25);
            ra.Add(23);
            ra.Add(70);
            ra.Add(85);
            Console.WriteLine("Without insert");
            foreach (object ob in ra)
            {
                Console.WriteLine("Roll no :" + ob);

            }
            Console.WriteLine(" ");

            Console.WriteLine("With insert");

            ra.Insert(2, 50);
            foreach(object ob in ra)
            {
                Console.WriteLine("Roll no :" + ob);

            }
            Console.ReadKey();
        }
    }
}
