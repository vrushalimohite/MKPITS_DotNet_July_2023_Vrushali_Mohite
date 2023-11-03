using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructer_class_product
{
    class Product
    {
        int productid;
        string productname;
        int price;
        int quantity;
        
        
        
     public Product()
          {
            productid=123;
            productname="book";
            price=200;
            quantity=1;

          }
        public void display()
        {
            Console.WriteLine("Product ID :" + productid);
            Console.WriteLine("Product Name :" + productname);
            Console.WriteLine("Product Price:" + price);
            Console.WriteLine("Product Quantity :" + quantity);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.display();
            Console.ReadLine();
        }
    }
}
