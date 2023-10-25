using System;
namespace program
{
    class program
    {
        static void bank(int act_no, int amt,int withdrawal,int deposit)
        {
            withdrawal = amt - withdrawal;
            Console.WriteLine();
            Console.WriteLine("withdrawal : Current Balance :"+withdrawal);
             deposit = amt + deposit;
            Console.WriteLine("Deposit : Current Amount :"+deposit);

        }
        static void Main()
        {
            int actno;
            Console.WriteLine("Enter Account no");
            actno = Convert.ToInt32(Console.ReadLine());
            int amt;
            Console.WriteLine("Enter Amount");
            amt= Convert.ToInt32(Console.ReadLine());
            int withdrawal;
            Console.WriteLine("Enter Withdrawal Amount");

            withdrawal = Convert.ToInt32(Console.ReadLine());
            int deposit;
            Console.WriteLine("Enter Deposit Amount");
            deposit= Convert.ToInt32(Console.ReadLine());

            bank(actno, amt, withdrawal, deposit);




        }
    }
}