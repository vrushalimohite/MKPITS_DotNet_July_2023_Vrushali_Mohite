using System;
namespace program
{
    class op
    {
        static void Main()
        {
            int num1, num2, add, sub, mul, choice;
            float divide, exit;
            Console.WriteLine("choice 1 for Addition");
            Console.WriteLine("choice 2 for Substraction")
            Console.WriteLine("choice 3 for Multiplication");
            Console.WriteLine("choice 4 for Division");
            Console.WriteLine("choice 5 for Exit");
            Console.WriteLine("Enter choice");
            choice= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter two num");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2= Convert.ToInt32(Console.ReadLine());

            if (choice==1)
            {
                add = num1 + num2;
                Console.WriteLine("Additions of two no" +" "+ add);

            }
            else if(choice==2)
            {
                sub = num1 - num2;
                Console.WriteLine("Substraction  of two no" +" "+ sub);

            }
            else if(choice==3)
            {
                mul = num1 * num2;
                Console.WriteLine("multiplication of two no"+" " + mul);

            }
            else if(choice==4)
            {
                divide = num1 / num2;
                Console.WriteLine("Divide of two no" + " " + divide);

            }
            else if(choice==5)
            {
                Console.WriteLine("Exit");

            }
            Console.ReadKey();

        }
    }
}
