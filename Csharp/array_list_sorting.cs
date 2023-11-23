using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace array_list_sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add(25);
            ar.Add(23);
            ar.Add(50);
            ar.Add(20);
            Console.WriteLine("Without sorting ...");
            foreach(object o in ar)
            {
                Console.WriteLine("Roll no :" + o);

            }
            Console.WriteLine("With sorting ...");
            ar.Sort();
            foreach(object o in ar)
            {
                Console.WriteLine("Roll no :" + o);


            }

            Console.ReadKey();

        }
    }
}
