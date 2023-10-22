using System;
namespace program
{
    class operations
    {
        static void Main()
        {
            int num1, num2, Choice;
            float result;
            Console.WriteLine("Enter Choice 1 for Addition");
            Console.WriteLine("Enter Choice 2 for Substraction");
            Console.WriteLine("Enter Choice 3 for  Multiplication");
            Console.WriteLine("Enter Choice 4 for Division");
            Console.WriteLine("Enter Choice 5 for  Exit");
            Choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number one");
            Console.WriteLine("Enter Number two");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());





            switch (Choice)
            {

                case 1:

                    result = num1 + num2;
                    Console.WriteLine("Addition of two no is =" + result);
                    break;
                case 2:
                   
                    result = num1 - num2;
                    Console.WriteLine("Substraction of two no is =" + result);
                    break;
                case 3:
                    
                    result = num1 * num2;
                    Console.WriteLine("Multiplication of two no is =" + result);
                    break;
                case 4:
                   
                    result = num1 / num2;
                    Console.WriteLine("Division of two no is =" + result);
                    break;
                case 5:
                    Console.WriteLine("Exit");
                    break;






                default:
                    Console.WriteLine("Invalid Choice no");
                    break;

            }
            Console.ReadKey();

        }
    }
}

