using System;
namespace program
{
    class greater
    {
        static void Main()
        {
            int num1, num2, num3;
            Console.WriteLine("Enter three numbers");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());

            if(num1>num2 && num1>num3)
            {
                Console.WriteLine("Num1 is greater than num2 & num3");
            }
            else if(num2>num3)
            {
                Console.WriteLine("Num2 is greater than num1 & num3");

            }
            else
            {
                Console.WriteLine("Num3 is greater than num2 & num1");

            }
            Console.ReadKey();

        }
    }
}
