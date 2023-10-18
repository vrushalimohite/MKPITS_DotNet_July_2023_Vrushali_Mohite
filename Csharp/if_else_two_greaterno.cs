using System;
namespace program
{
    class greater
    {
        static void Main()
        {
            int num1, num2;
            Console.WriteLine("Enter number one");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number two");
            num2 = Convert.ToInt32(Console.ReadLine());
            if(num1>num2)
            {
                Console.WriteLine("Num1 is greter than num2");
            }
            else
            {
                Console.WriteLine( "num2 is greter than num1");
            }

            Console.ReadKey();

        }
    }
}
