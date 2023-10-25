using System;
namespace program
{
    class program
    {
        static void display(string name)
        {
            Console.WriteLine("Welcome Friend"+" "+name+"!");
            Console.WriteLine("Have a nice day!");

        }

        static void Main()
        {
            string name;
            Console.WriteLine("Enter name");
            name = (Console.ReadLine());
            display(name);
            Console.ReadKey();

        }
    }
}