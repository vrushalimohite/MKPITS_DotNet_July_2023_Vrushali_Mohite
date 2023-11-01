using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_bank_account
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BankAccount b1 = new BankAccount();
            b1.AccountNumber = 154;
            b1.AccountHolderName = "Vrushali";
            b1.Balance = 1000;
            b1.display();

            BankAccount b2 = new BankAccount();
            b2.AccountNumber = 1111154;
            b2.AccountHolderName = "Mayuri";
            b2.Balance = 5000;
            b2.display();

            b1.transfer(b2);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Balance After transaction :");
            Console.WriteLine("--------------------------------------------");


            b1.showbalance();
            b2.showbalance();
            Console.ReadKey();

        }
        class BankAccount
        {
            public int AccountNumber { get; set; }
            public string AccountHolderName { get; set; }
            public int Balance { get; set; }
            public void display()

            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Account details of customer :");
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Account Numbder :"+AccountNumber);
                Console.WriteLine("Account Holder Name :" + AccountHolderName);
                Console.WriteLine("Balance :" + Balance);


            }
            public void transfer(BankAccount ba)
            {
                Balance = Balance + ba.Balance;
                ba.Balance = 0;
            }
            public void showbalance()
            {
                Console.WriteLine("Current Balance for Account no :{0} is Balance :{1}", AccountNumber, Balance);

            }
        }
    }
}
