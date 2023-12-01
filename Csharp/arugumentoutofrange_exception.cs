using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace outofmemoryexception_error
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Raj";
            string subject = "Digital";
            Console.WriteLine("Length of name :" + name.Length);
             StringBuilder sb = new StringBuilder(name.Length,name.Length);
            try
            {
                sb.Append(subject);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
