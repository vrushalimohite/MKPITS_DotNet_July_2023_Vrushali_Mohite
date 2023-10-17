using System;
namespace program
{
    class op
    {
        static void Main()
        {
            int num1, num2, add, sub, mul, no;
            float divide, exit;
            Console.WriteLine("Enter two num");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter two num");
            no= Convert.ToInt32(Console.ReadLine());

            if (no==1)
            {
                add = num1 + num2;
                Console.WriteLine("Additions of two no" +" "+ add);

            }
            else if(no==2)
            {
                sub = num1 - num2;
                Console.WriteLine("Substraction  of two no" +" "+ sub);

            }
            else if(no==3)
            {
                mul = num1 * num2;
                Console.WriteLine("multiplication of two no"+" " + mul);

            }
            else if(no==4)
            {
                divide = num1 / num2;
                Console.WriteLine("Divide of two no" + " " + divide);

            }
            else if(no==5)
            {
                Console.WriteLine("Exit");

            }
            Console.ReadKey();

        }
    }
}
