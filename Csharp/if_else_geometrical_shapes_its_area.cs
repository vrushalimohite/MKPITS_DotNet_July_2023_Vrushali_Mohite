using System;
namespace program
{
    class shape
    {
        static void Main()
        {
            int l, b, b1, h, r, b2;
            float area;
            int choice;
            Console.WriteLine("Enter Choice 1 for arae of circle");
            Console.WriteLine("Enter Choice 2 for area of triangle");
            Console.WriteLine("Enter Choice 3 for arae of Rectangle");
            Console.WriteLine("Enter Choice 1 for arae of Parallelogram");
            choice = Convert.ToInt32(Console.ReadLine());

            if(choice==1)
            {
                Console.WriteLine("Enter radius");
                r = Convert.ToInt32(Console.ReadLine());
                area = 3.14f * r * r;
                Console.WriteLine("arae of circle :"+" "+area);
            }
            else if(choice==2)
            {
                Console.WriteLine("Enter base");
                Console.WriteLine("Enter height");
                b = Convert.ToInt32(Console.ReadLine());
                h= Convert.ToInt32(Console.ReadLine());
                area = 0.5f * b * h;
                Console.WriteLine(" area of triangle :"+" "+area);
            }
             else if(choice==3)
             {
                Console.WriteLine("Enter length");
                Console.WriteLine("Enter breadth");
                b1 = Convert.ToInt32(Console.ReadLine());
                l = Convert.ToInt32(Console.ReadLine());
                area = l * b1;
                Console.WriteLine("arae of Rectangle"+" "+area);
             }
            else if(choice==4)
            {
                Console.WriteLine("Enter base");
                Console.WriteLine("Enter height");
                b = Convert.ToInt32(Console.ReadLine());
                h = Convert.ToInt32(Console.ReadLine());
                area = b * h;
                Console.WriteLine("arae of Parallelogram"+" "+area);
            }
            else
            {
                Console.WriteLine("Invalid choice number");

            }
        }
    }
}
