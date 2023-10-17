using System;
namespace program
{
    class day_no
    {
        static void Main()
        {
            int day_no;
            Console.WriteLine("Enter Day no 1 to 7");
            day_no = Convert.ToInt32(Console.ReadLine());
            



            if (day_no==1)
            {
                Console.WriteLine("Monday");
            }
            else if (day_no==2)
            {
                Console.WriteLine("tuesday");

            }
            else if (day_no==3)
            {
                Console.WriteLine("Wednesday");

            }
            else if (day_no==4)
            {
                Console.WriteLine("Thursday");

            }
            else if (day_no==5)
            {
                Console.WriteLine("friday");

            }
            else if(day_no==6)
            {
                Console.WriteLine("Saturday");

            }
            else if(day_no==7)
            {
                Console.WriteLine("Sunday");

            }
            Console.ReadKey();
        }
    }
}

