using System;
namespace program
{
    class numbers
    {
        static void Main()
        {
            int num;
            Console.WriteLine("Enter Day no 1 to 10");
            num= Convert.ToInt32(Console.ReadLine());




            if (num == 1)
            {
                Console.WriteLine("One");
            }
            else if (num == 2)
            {
                Console.WriteLine("two");

            }
            else if (num== 3)
            {
                Console.WriteLine("Three");

            }
            else if (num == 4)
            {
                Console.WriteLine("four");

            }
            else if (num== 5)
            {
                Console.WriteLine("five");

            }
            else if (num == 6)
            {
                Console.WriteLine("six");

            }
            else if (num== 7)
            {
                Console.WriteLine("Seven");

            }
            else if (num==8)
            {
                Console.WriteLine("Eight");

            }
            else if(num==9)
            {
                Console.WriteLine("Nine");

            }
            else if(num==10)
            {
                Console.WriteLine("Ten");

            }
            else
            {
                Console.WriteLine("Invalid no");

            }
            Console.ReadKey();
        }
    }
}


