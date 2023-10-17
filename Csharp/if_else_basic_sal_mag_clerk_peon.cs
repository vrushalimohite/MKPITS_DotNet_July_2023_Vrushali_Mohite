using System;
namespace program
{
    class if_else
    {
        static void Main()
        {
            int empno, basic_sal, total_sal;
            string empname, designation;
            float bonus = 0;

            Console.WriteLine("enter empno");
            empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter empname");
            empname =(Console.ReadLine());
            Console.WriteLine("Enter basic sal");
            basic_sal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter designation");
            designation =(Console.ReadLine());

            if (designation == "maneger")
            {
                bonus = basic_sal * 0.55f;
            }
            else if (designation == "clerk")
            {
                bonus = basic_sal * 0.25f;
            }
            else if (designation == "peun");
            {
                bonus = basic_sal * 0.10f;
            }
           else
            {
                Console.WriteLine("invalid designation");
            }
            total_sal = basic_sal + bonus;
            Console.WriteLine("empno:{0},empname:{1},basic_sal:{2},designation:{3}", empno, empname, basic_sal, designation);
            Console.WriteLine("");
            Console.WriteLine("bonus={0},total_sal={1}", bonus, total_sal);


        }
    }
}
