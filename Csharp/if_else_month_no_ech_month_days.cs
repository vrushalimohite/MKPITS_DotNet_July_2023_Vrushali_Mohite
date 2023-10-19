using System;
namespace program
{
    class display
    {
        static void Main()
        {
            int num;
            Console.WriteLine("Enter month number");
            num = Convert.ToInt32(Console.ReadLine());
            if(num==1 || num==3 || num==5 || num==7 || num==8 || num==10 || num==12)
            {
                Console.WriteLine("31 Days");
            }
            else if(num==4 || num==6 || num==9 || num==11)
            {
                Console.WriteLine("30 Days");

            }
            else if(num==2)
            {
                Console.WriteLine("28 Days");

            }
            else
            {
                Console.WriteLine("Invalid month number");

            }
        }
    }
}
