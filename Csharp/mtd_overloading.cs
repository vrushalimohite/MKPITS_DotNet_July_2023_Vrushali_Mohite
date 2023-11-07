using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mtd_overloading_ex2
{ 

    class calculate
    {
    public void sub(int n1,int n2)
    {
        int res = n1 - n2;
        Console.WriteLine("Result :"+res);
    }
    public void sub(float n1,float n2)
    {
        float res= n1 - n2;
        Console.WriteLine("Result :"+res);
    }
}
    internal class Program
    {
        static void Main(string[] args)
        {
        calculate c = new calculate();
        c.sub(10, 8);
        c.sub(1.2f, 3.5f);
        Console.ReadKey();
        }
    }
}
