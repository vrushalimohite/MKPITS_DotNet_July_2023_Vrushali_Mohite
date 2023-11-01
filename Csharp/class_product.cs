/*Product Class: Define a Product class with properties for Name, Price, and StockQuantity.
 * Create an instance of the Product class and simulate a purchase where you reduce the 
 * stock quantity by a certain amount. Display the updated stock quantity.*/




using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int squant = 10;
           Product p = new Product();
            Console.WriteLine(" For Shopkeeper ");

            Console.WriteLine("Enter Product Name :");
            string p_name = (Console.ReadLine());

            Console.WriteLine("Enter Product Quantity:");
            int p_pquan= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Amount:");
            int p_price = Convert.ToInt32(Console.ReadLine());

            if (p_pquan > 0 && p_pquan <= squant)
            {
                squant = squant -p_pquan;
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------");

                Console.WriteLine("Message for Shopkeeper");
                Console.WriteLine();

                Console.WriteLine(" Remaining updated stock quantity :" + squant);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("Insufficient Quantity");

            }

            p.getdata(p_name, p_price, p_pquan);
            p.displaydata();
            Console.ReadKey();
            
        }
        class Product
        {
            string name;
            int pquan;
            int price;

            

            public void getdata(string name, int price, int pquan)
            {
                this.name = name;
             
                this.price = price;
                this.pquan = pquan;


            }
            public void displaydata()
            {



                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine();


                Console.WriteLine("Bill for Customer :");
                Console.WriteLine();


                Console.WriteLine("Product Name :"+name);
                Console.WriteLine("Price:" + price);
                Console.WriteLine("Product Quantity :" + pquan);


                int total = price * pquan;
                Console.WriteLine("Price*Product Quantity= Total Amount:" + total);
                Console.WriteLine();

                Console.WriteLine();
               

            }
        }
    }
}
