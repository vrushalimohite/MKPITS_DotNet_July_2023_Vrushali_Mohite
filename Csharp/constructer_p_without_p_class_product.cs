/*create a class employee having fields empno,empname , designation and salary
create a constructor with no parameters and create another parameterized constructor 
with 4 parameters*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructer_no_p_with_p_class_employee
{
    class Product
    {
        int productno;
        string productname;
        int price;
        int quantity;
        public Product()
        {
            productno = 546;
            productname = "Book";
            price = 550;
            quantity = 5;

        }
        public Product(int productno, string productname, int price, int quantity)
        {
            this.productno = productno;
            this.productname = productname;
            this.price = price;
            this.quantity = quantity;

        }
        public void display()
        {
            Console.WriteLine("Product NO :" + productno);
            Console.WriteLine("Product Name :" + productname);
            Console.WriteLine("price :" + price);
            Console.WriteLine("Quantity :" + quantity);

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Product 1 details with No parameter");
            Console.WriteLine("");

            Product p = new Product();
            p.display();
            Console.WriteLine(" ");
            Console.WriteLine(" Product 2 details with parameter");
            Console.WriteLine(" ");
            Product p2 = new Product(4565, "Pen", 500,4);
            p2.display();
            Console.ReadKey();

        }
    }
}
