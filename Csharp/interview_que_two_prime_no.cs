using System;
namespace program
{
    class Mainclass
    {
        public static Boolean primetime(int num) //int primetime(int num)
        {
            int counter = 2;
            int flag = 0;
            while (num % counter == 0)
            {
                flag = 1;
                break;
            }
            counter++;

            if (flag == 0)
            {
                return true; //1

            }
            else
            {
                return false; //0

            }
        }
        static void Main()
        {
            int number;
            Console.WriteLine("Enter Number");
            number = Convert.ToInt32(Console.ReadLine());
            bool result1 = primetime(number);  //int
            Console.WriteLine(result1);
            Console.ReadKey();
        }
    }
}
