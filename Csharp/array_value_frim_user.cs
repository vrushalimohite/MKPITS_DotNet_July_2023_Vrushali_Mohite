//accept the value from the user to store in array.
using System;
namespace program
{
    class program
    {
        static void Main(string[]args)
        {
            int[] num = new int[3];
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("Enter three number");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<3;i++)
            {
                Console.WriteLine("num{0}={1}",i,num[i]);
            }
            Console.ReadKey();
        }
    }
}