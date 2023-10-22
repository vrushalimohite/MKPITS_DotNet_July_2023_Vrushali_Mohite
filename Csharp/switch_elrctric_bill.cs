using System;
namespace program
{
    class bill
    {
        static void Main()
        {
            string name;
            int id;
            double surchage = 0;
            double charge, totalamt = 0;
            

            Console.WriteLine("Enter Customer Name");
            name = (Console.ReadLine());
            Console.WriteLine("Enter Customer ID no");
            id =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Charge");
            charge = Convert.ToDouble(Console.ReadLine());
            switch (charge)
            {
                case 200: //charge
                    totalamt = charge * 1.20;
                    Console.WriteLine("Total Amount :" + totalamt);

                    break;
                case 400:
                    totalamt = charge * 1.50;
                    Console.WriteLine("Total Amount :" + totalamt);

                    break;
                case 600:
                    totalamt = charge * 1.80;
                    Console.WriteLine("Total Amount :" + totalamt);

                    break;
                case 800:
                    totalamt = charge * 2;
                    Console.WriteLine("Total Amount :" + totalamt);

                    break;
            }   


                    if (totalamt >= 400)
                    
                        surchage = totalamt * 15 / 100.0f;
                        
                    
                        double netamt = totalamt + surchage;
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("cutomer Name :"+name);
                        Console.WriteLine("cutomer ID :" + id);
                     
                        Console.WriteLine("Amount charge :" + totalamt);
                        Console.WriteLine("Surchage amount :" + surchage);
                        Console.WriteLine("Net Amount paid by the user :" + netamt);
                    
                    



            



        }
    }
}
