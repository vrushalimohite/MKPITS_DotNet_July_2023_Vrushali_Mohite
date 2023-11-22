using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation_ex
{
    class person
    {
        public string name { get; set; }
        

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.name = "Raj";
            Console.WriteLine("Name :" + p.name);
            Console.ReadKey();
        }
    }
}
