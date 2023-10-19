using System;
namespace program
{
    class operation
    {
        static void Main()
        {
            int num1, num2;
            float result;
            int choice;
            Console.WriteLine("Enter Choice 1 for Addition");
            Console.WriteLine("Enter Choice 2 for Substraction");
            Console.WriteLine("Enter Choice 3 for Multiplication");
            Console.WriteLine("Enter Choice 4 for Division");
            Console.WriteLine("Enter Choice 5 Exit");


            choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Enter number 1");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2");

                num2 = Convert.ToInt32(Console.ReadLine());

                result = num1 + num2;
                Console.WriteLine("Addition :" + " " + result);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter number 1");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2");
                num2= Convert.ToInt32(Console.ReadLine());
                result = num1 - num2;
                Console.WriteLine(" Substraction :" + " " + result);
            }
            else if (choice == 3)
            {
                Console.WriteLine("Enter number 1");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2");
                num2= Convert.ToInt32(Console.ReadLine());
                result = num1 * num2;
                Console.WriteLine("Multiplication :" + " " + result);
            }
            else if (choice == 4)
            {
                Console.WriteLine("Enter number 1");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter number 2");
                num2= Convert.ToInt32(Console.ReadLine());
                result = num1 / num2;
                Console.WriteLine("Division :" + " " + result);
            }
            else if(choice==5)
            {
                Console.WriteLine("Exit");

            }
            else
            {
                Console.WriteLine("Invalid choice number");

            }
        }
    }
}



