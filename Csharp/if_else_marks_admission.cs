using System;
namespace program
{
    class admission
    {
        static void Main()
        {
            int math, chem, phy;
            float total;
            Console.WriteLine("Enetr math Marks");
            math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enetr chem Marks");
            chem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enetr phy Marks");
            phy = Convert.ToInt32(Console.ReadLine());
            total = math + chem + phy;
            Console.WriteLine("Total Marks:"+total);
            if(total>=230)
            {
                Console.WriteLine("Candidate is Eligible for Addmision");

            }
            else
            {
                Console.WriteLine("Candidate is Not Eligible for Addmision");

            }
            Console.ReadKey();






        }
    }
}
