﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_customer_details
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer cust = new Customer();
            cust.customer_code = 123;
            cust.customer_name = "vrush";
            Console.WriteLine("Customer code" + cust.customer_code);
            Console.WriteLine("Customer name" + cust.customer_name);
            Console. ReadKey();
        }
        class Customer
        {
           public int customer_code;
           public string customer_name;
           
        }

    }

}
