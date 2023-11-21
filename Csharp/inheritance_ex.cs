
/*Create a base class called Vehicle with attributes like "make" and "model."
Derive a class called Car from the Vehicle class, adding specific attributes like "numDoors" and "fuelType."
Instantiate an object of the Car class and demonstrate inheritance by accessing attributes from both the base
and derived classes.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_ass
{
    class Vehicle
    {
        public int year=2022;
        public string model="BMW";
    }
    class Car: Vehicle
    {
        public int numdoorss=15;
        public string fueltype="Gas";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Console.WriteLine("Make year :" + c.year);
            Console.WriteLine("model :" + c.model);
            Console.WriteLine("Numbers of Doors:" + c.numdoorss);
            Console.WriteLine("fueltype :" + c.fueltype);
            Console.ReadKey();
        }
    }
}
