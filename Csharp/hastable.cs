using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace hashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("001","Ravi");
            ht.Add("002", "Kunal");
            ht.Add("003", "pratik");
            ht.Add("004", "Summer");
            if (ht.ContainsValue("prat")) 
            {
                Console.WriteLine("Already exit");
            }
            else
            {
                ht.Add("005", "Rajesh");
            }
            ICollection key = ht.Keys;
            foreach(string k in key)
            {
                Console.WriteLine(k + ":" + ht[k]);
            }
            Console.ReadKey();

        }
    }
}
