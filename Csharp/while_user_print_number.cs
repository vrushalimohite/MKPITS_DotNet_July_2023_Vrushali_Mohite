/*using System;
namespace program
{
    class print
    {
        static void Main()
        {
            int num1,num2;
            Console.WriteLine("Enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());


            while (num1 ==num2)
            {
                Console.WriteLine(num1);
            }

        }
    }
}


using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int cnt = 10;
            while(cnt>0)
            {
                Console.WriteLine(cnt);
                cnt--;
            }
            
        }
    }
}


using System;
namespace program
{
    class program
    {
        static void Main()
        {
            int num;
            int fact = 1;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            while(num>0)
            {
                fact = fact * num;
                num--;
            }
            Console.WriteLine("factorial :" + fact);
            Console.ReadKey();

        }
    }
}

using System;
namespace program
{
    class program
    {
        static void  Main()
        {
            int num;
            Console.WriteLine("enter number");
            num = Convert.ToInt32(Console.ReadLine());
            while(num%2==0)
            {
             
                num++;
            }
        }
    }
}*/

using System;
namespace prrogram
{
    class program
    {
        static void Main()
        {
            int cnt = 1;
            while (cnt <= 10)
                if (cnt % 2 == 0)
                    Console.WriteLine(cnt);
            cnt++;
        }
    }
}
