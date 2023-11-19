using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritace
{
    class person
    {
        public int age = 45;
        public string name = "Aniket";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            person p = new person();
            Console.WriteLine("Age :" + p.age);
            Console.WriteLine("Name :" + p.name);
            Console.ReadKey();
        }
    }
}
