using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_subject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> li = new List<string>();
            li.Add("C#");
            li.Add("java");
            li.Add("python");
            li.Add("DotNet");
            Console.WriteLine(li.Contains("C#"));
            Console.WriteLine(li[1]);
            Console.WriteLine(li[2]);
            Console.WriteLine(li[3]);

            li.Remove("python");
            Console.WriteLine("----Remove----");

            foreach (string s in li)
            {
                Console.WriteLine(s);

            }
            Console.WriteLine(li.Contains("C#"));
            

            li.Insert(2, "php");
            Console.WriteLine("---insert----");

            foreach (string s in li)
            {


                Console.WriteLine(s);

            }
            li.Sort();
            Console.WriteLine("---sorting----");

            foreach (string s  in li)
            {
                Console.WriteLine(s);

            }
            Console.ReadKey();

        }
    }
}
