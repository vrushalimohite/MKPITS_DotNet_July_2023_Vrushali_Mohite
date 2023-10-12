using System;
namespace addition
{
class addition
{
    static void Main(string[] args)
    {
    int num1,num2, addition;
    Console.WriteLine("Enter num1");
        num1=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter num2");
        num2=Convert.ToInt32(Console.ReadLine());
        addition=num1+num2;
        Console.WriteLine("Addition of two no ="+addition);
        Console.ReadKey();
}
}
}
