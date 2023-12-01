using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace user_defined_exception
{
    public class temp:ApplicationException
    {
        public temp(string message):base (message)
        {

        }
    }
    public class temperature
    {
        int temp1 = 0;
        public void showtemp()
        {
          if(temp1==0)
            {
                throw (new temp("temperature could be found"));
            }
            else
            {
                Console.WriteLine("Temperature {0}" + temp1);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            temperature t = new temperature();
            try
            {
                t.showtemp();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();
        }
    }
}
