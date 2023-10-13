using System;
namespace program
{
    class person
    {
        static void Main()
        {
            int height;
            Console.WriteLine("Enetr height");
            height = Convert.ToInt32(Console.ReadLine());
            if (height<150)
            {
                Console.WriteLine(+height+ " " + "it is Dwarf");

            }
            else
            {
                Console.WriteLine(+height + " " + "it is not Dwarf");//dwarf means thingna(height is less)

            }
            Console.ReadKey();

        }
    }
}

