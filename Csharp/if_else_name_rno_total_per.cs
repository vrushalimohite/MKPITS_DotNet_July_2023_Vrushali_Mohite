using System;
namespace program
{
    class admission
    {
        static void Main()
        {
            int rollno, math, chem, phy;
            string name, division;
            float total, per;

            Console.WriteLine("Enetr Name");
            name = (Console.ReadLine());
            Console.WriteLine("Enetr Roll no");
            rollno = Convert.ToInt32(Console.ReadLine());



            Console.WriteLine("Enetr math Marks");
            math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enetr chem Marks");
            chem = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enetr phy Marks");
            phy = Convert.ToInt32(Console.ReadLine());
            total = math + chem + phy;
            Console.WriteLine("  ");
            Console.WriteLine("Total Marks:" + total);
            per = (total / 300.0f) * 100.0f;
            Console.WriteLine("percentages %:"+per);

            if (per>=75)
            {
                Console.WriteLine("Division Result is Destinction");

            }
            else if(per>=60&&per<75)
            {
                Console.WriteLine("Division result is first class");

            }
            else if(per<=60)
            {
                Console.WriteLine("Division result is Fail");

            }
            Console.WriteLine("name:{0},rollno:{1}",name,rollno);

            Console.ReadKey();






        }
    }
}

