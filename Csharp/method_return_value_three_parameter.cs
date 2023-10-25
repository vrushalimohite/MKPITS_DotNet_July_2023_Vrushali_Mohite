using System;
namespace program
{
    class program
    {
        static int display(int num1,int num2,char op)
        {
            int res = 0;
            if (op == '+')
                res = num1 + num2;
            else if (op == '*')
                res = num1 * num2;
            else if (op == '-')
                res = num1 - num2;
            else if (op == '/')
                res = num1 / num2;
            else
                Console.WriteLine("Invalid operator");
            return res;
        }
        static void Main()
        {
            int number1;
            Console.WriteLine("Enter num1");
            number1 = Convert.ToInt32(Console.ReadLine());
            int number2;
            Console.WriteLine("Enter num2");
            number2 = Convert.ToInt32(Console.ReadLine());

            char oper;
            Console.WriteLine("Enter operator (+,-,*,/)");

            oper = Convert.ToChar(Console.ReadLine());

            int result = display(number1, number2, oper);
            Console.WriteLine("Result :"+result);

        }
    }
}