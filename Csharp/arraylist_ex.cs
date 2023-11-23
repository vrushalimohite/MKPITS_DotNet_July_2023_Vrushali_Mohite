using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace array_list_ex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList ar = new ArrayList();
            ar.Add("Raj");
            ar.Add("Shivraj");
            ar.Add("Shivay");
            foreach(object ob in ar)
            {
                Console.WriteLine("Name :" + ob);
            }
            Console.ReadKey();
        }
    }
}
