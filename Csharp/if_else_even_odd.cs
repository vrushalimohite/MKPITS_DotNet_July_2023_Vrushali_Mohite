using System;
namespace program
{
    class even
    {
        static void Main()
        {
            int num;
            Console.WriteLine("Enter no");
            num = Convert.ToInt32(Console.ReadLine());
            if(num%2==0)
            {
                Console.WriteLine("Enter no is Even");
            }
            else
            {
                Console.WriteLine("Enter no is Odd");

            }
            Console.ReadKey();
        }
    }
}
