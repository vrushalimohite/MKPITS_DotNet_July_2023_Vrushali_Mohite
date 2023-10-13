using System;
namespace program
{
    class equal
    {
        static void Main()
        {
            int num1, num2;
            Console.WriteLine("Enter two no");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Both No are equal");
            }
            else
            {
                Console.WriteLine("Both No are not equal");
            }
            Console.ReadKey();

        }
    }
}
