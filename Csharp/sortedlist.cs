using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SORTEDlIST
{
    internal class Program
    {

        static void Main(string[] args)
        {
            SortedList sl = new SortedList();

            sl.Add("03", "nisha");
            sl.Add("02", "kisha");
            sl.Add("05", "aisha");
            sl.Add("04", "lisha");
            if (sl.ContainsValue("sisha")) 
            {
                Console.WriteLine("Already exit");

            }
            else
            {
                sl.Add("08", "mina");
            }
            ICollection key = sl.Keys;
            foreach(string s in key)
            {
                Console.WriteLine(s + ":" + sl[s] + "\n");
            }

            Console.ReadKey();
        }
    }
}
