﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_customer_mtd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.getdata(123, "vrushali");
            cust.displaydata();
            Console.ReadKey();
        }
        class Customer
        {
            int customer_code;
            string customer_name;

            public void getdata(int cc, string cn)
            {
                customer_code = cc;
                customer_name = cn;
            }
            public void displaydata()
            {
                Console.WriteLine("Customer code :" + customer_code);
                Console.WriteLine("Customer name :" + customer_name);
            }
        }
    }
}
