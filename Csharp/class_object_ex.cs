/*Provide an example of a simple class in C# with at least two attributes and one method.
Create an object of the class you defined and demonstrate how to access its attributes and call its method.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_ex
{
    class Square
    {
        public int num;
        public int square;

        public void getdata(int num)
        {
            this.num = num;
            

        }
        public void display()
        {
            square = num * num;
            Console.WriteLine("square is :" + square);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Square s = new Square();
            Console.WriteLine("Enter number");
             int num = Convert.ToInt32(Console.ReadLine());
            s.getdata(num);
            s.display();
            Console.ReadLine();

        }
    }
}
