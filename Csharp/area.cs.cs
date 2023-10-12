using System;
namespace area
{
    class area

    {
      public  static void Main()
    {
     int l, b, area;
    Console.WriteLine("Enter length");
    l=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Breadth");
    b=Convert.ToInt32(Console.ReadLine());
    area=l* b;
        Console.WriteLine("Area is="+area);
    Console.ReadKey();
}
}
}

