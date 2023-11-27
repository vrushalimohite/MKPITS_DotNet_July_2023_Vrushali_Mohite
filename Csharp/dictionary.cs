using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> domains = new Dictionary<string, string>();
            domains.Add("de", "Germany");
            domains.Add("sk", "slovakia");
            domains.Add("ru", "Russia");
            domains.Add("in", "india");
            domains.Add("us", "united state");
            Console.WriteLine(domains["sk"]);
            Console.WriteLine(domains["de"]);
            Console.WriteLine("Dictionary has {0} items", domains.Count);
            Console.WriteLine(" ");
            Console.WriteLine("Keys of the dictionary");
            List<string> keys = new List<string>(domains.Keys);
            foreach(string key in keys)
            {
                Console.WriteLine("{0}", key);
            }
            Console.WriteLine("values of the dictionary:");
            List<string> vals = new List<string>(domains.Values);
            foreach(string val in vals)
            {
                Console.WriteLine("{0}", val);
            }
            Console.WriteLine("keys ans values of the dictionary");
            foreach(KeyValuePair<string,string>kvp in domains)
                {
                Console.WriteLine("key {0},value={1}", kvp.Key, kvp.Value);
            }
            Console.ReadKey();
        }
    }
}
