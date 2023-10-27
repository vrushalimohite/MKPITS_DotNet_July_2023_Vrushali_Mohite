using System;
namespace program
{
    class program
    {
        static void local()
        {
           int  num = 10;
            Console.WriteLine("num is inside the method" + num);

            
        }
        static void Main()
        {


            local();
            int num = 5; 
            Console.WriteLine("num is outside the method" + num);
        }



    }
}