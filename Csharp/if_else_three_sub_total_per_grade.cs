using System;
namespace program
{
    class subject
    {
        static void Main()
        {
            int math, phy, chem, total=0;
            float  per;
            string grade;

            Console.WriteLine("Enter math marks");
            Console.WriteLine("Enter math phy");
            Console.WriteLine("Enter math chem");
            math = Convert.ToInt32(Console.ReadLine());
            phy = Convert.ToInt32(Console.ReadLine());
            chem= Convert.ToInt32(Console.ReadLine());
            
            total = math + phy + chem;
            Console.WriteLine("Total of 3 subject :" + " " + total);
            Console.WriteLine("/t");

            per = total / 300.0f * 100.0f;
            Console.WriteLine("percentage :" + " " + per);
            Console.WriteLine("/t");
            
            if(per>=75)
            {
                Console.WriteLine("A++");
            }
            else if(per<=75 && per>=60)
            {
                Console.WriteLine("B");

            }
            else
            {
                Console.WriteLine("C");

            }

            Console.ReadKey();

        }
    }
}
