using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_single_level_mtd_car
{
    public class car
    {
        public void start()
        {
            Console.WriteLine("Car is start...");
        }
    }
    public class car1 : car
    {
        public void stop()
        {
            Console.WriteLine("Car is stop");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            car1 c = new car1();
            c.start();
            c.stop();
            Console.ReadKey();
        }
    }
}
