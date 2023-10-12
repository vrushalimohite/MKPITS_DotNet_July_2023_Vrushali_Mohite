using System;
namespace program
{
    class op
    {
        static void Main()
        {
            int num1 = 25, num2 =4, result = 0;
            result = num1 + num2;
            Console.WriteLine("Addition =" + result);

            result = num1 - num2;
            Console.WriteLine("Subtraction =" + result);

            result = num1 * num2;
            Console.WriteLine("multiplication =" + result);

            result = num1 / num2;
            Console.WriteLine("Divide =" + result);

            result = num1 % num2;

            Console.WriteLine("Modolo =" + result);


        }
    }
}



