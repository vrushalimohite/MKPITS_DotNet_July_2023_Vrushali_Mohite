using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_multilevel_inheritance
{
   public  class person
    {
        public void start()
        {
            Console.WriteLine("-----Car is start-------");
        }
    }
    public class students : person
    {
        public void pause()
        {
            Console.WriteLine("-----Car is pause-----");
        }
    }
    public class employee : students
    {
        public void stop()
        {
            Console.WriteLine("------Car is stop----");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee e = new employee();
            e.start();
            e.pause();
            e.stop();
            Console.ReadKey();
        }
    }
}
