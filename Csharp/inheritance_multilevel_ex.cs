using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_multilevel_ex
{
    public class Suzuki
    {
        public void start()
        {
            Console.WriteLine("car is start");
        }
    }
    public class maroti : Suzuki
    {
        public void pause()
        {
            Console.WriteLine("Car is pause");
        }
    }
    public class honda : maroti
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
            honda d1 = new honda();
            d1.start();
            d1.pause();
            d1.stop();
            Console.ReadKey();
        }
    }
}
