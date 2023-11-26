

/*create a queue collection of customer class(custid,custname,email,mobno)*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace customer
{
    class customer
    {
        public int custid;
        public string custname;
        public string email;
        public double mono;
        public customer(int custid, string custname, string email, double mono)
        {
            this.custid = custid;
            this.custname = custname;
            this.email = email;
            this.mono = mono;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            customer c1 = new customer(123, "Rajesh", "Rajesh123@gmail.com", 5236418789);
            customer c2 = new customer(2143, "Mahesh", "manu1254@gmail.com",1254878956);
            customer c3 = new customer(55123, "Ridhi",  "ridhu254@gmail.Com",2156349875);
            customer c4 = new customer(564123, "Shivay",  "shiv42@gmail.Com",4569812545);

            Queue s = new Queue();
            s.Enqueue(c1);
            s.Enqueue(c2);
            s.Enqueue(c3);
            s.Enqueue(c4);
            foreach (customer cus in s)
            {
                Console.WriteLine("Customer ID :"+cus.custid);
                Console.WriteLine("Customer Name:" + cus.custname);
                Console.WriteLine("Customer Gmail :" + cus.email);
                Console.WriteLine("Customer Mobail NO:" + cus.mono);


                Console.WriteLine("------------------------------------------");


            }
            customer p = (customer)s.Dequeue();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(" ");


            Console.WriteLine("After Pop");
            Console.WriteLine(" ");

            foreach (customer cus in s)
            {
                Console.WriteLine("Customer ID :" + cus.custid);
                Console.WriteLine("Customer Name:" + cus.custname);
                Console.WriteLine("Customer Gmail :" + cus.email);
                Console.WriteLine("Customer Mobail NO:" + cus.mono);
                Console.WriteLine(" ");


            }

            Console.ReadKey();



        }
    }
}
