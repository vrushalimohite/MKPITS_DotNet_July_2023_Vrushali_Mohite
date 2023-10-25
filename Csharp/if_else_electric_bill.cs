using System;
namespace program
{
    class bill
    {
        static void Main()
        {
            string name;
            int idno;
            float unit;
            double total=0, surchage = 0, netamt;
            Console.WriteLine(" Customer Name");
            name=(Console.ReadLine());

            Console.WriteLine(" Customer Id no");
            idno = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Unit Consumed");
            unit = Convert.ToInt32(Console.ReadLine());
             if(unit>0 && unit<=199)
            {
                total = unit * 1.20f;


            }
            else if( unit>=200 && unit<=400)
            {
                total = unit * 1.50f;

            }
            else if(unit>400 && unit<=600)
            {
                total = unit * 1.80f;

            }
            else if(unit>600)
            {
                total = unit * 2.00f;

            }
             if(total>=400)
            
            surchage = total * 15 / 100.0;
            netamt = total + surchage;
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Customer Name :" + " " + name);
            Console.WriteLine("Customer idno :" + " " + idno);
            Console.WriteLine("unit Consumed :" + " " + unit);
            Console.WriteLine("Amount Charge :" +" "+ total);
            Console.WriteLine("Surchage Amount :" +" "+ surchage);

            Console.WriteLine("Net Amount paid by the customed  :" + netamt);



       }
    }
}
