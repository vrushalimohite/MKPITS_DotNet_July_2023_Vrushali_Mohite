using System;
namespace program
{
    class program
    {
        static void display(int num)
        {
            int cnt = 2;
            int flag = 0;
            while(num%cnt==0)
            {
                flag = 1;
                break;
            }
            cnt++;
            if(flag==0)
            {
                Console.WriteLine("It is prime number");
            }
            else
            {
                Console.WriteLine("It is  NOt prime number");

            }
        }
        static void Main()
        {
            display(10);
        }
    }
}