/*Bank Customer Class: Create a BankCustomer class with properties for CustomerName, AccountNumber, 
 * and Balance. Instantiate the BankCustomer class and simulate deposits and withdrawals from the 
 * customer's account. Display the final balance*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_bank_two
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank_Customer bc = new Bank_Customer();
            Console.WriteLine("Enter CustomerName, AccountNumber,and Amount");
            string cn = (Console.ReadLine());
            int an=Convert.ToInt32(Console.ReadLine());
            int amt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Deposit Amount :");
            int deposit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter withdrawal Amount :");

            int with = Convert.ToInt32(Console.ReadLine());

            bc.getdata(cn, an, amt,deposit,with);
            bc.displaydata();
            Console.ReadKey();
        }
        class Bank_Customer
        {
            string cn;
            int an;
            int bal;
            int deposit;
            int with;
            int amt;


            public void getdata(string cn, int an, int amt,int deposit,int with)
            {
                this.cn = cn;
                this.an = an;
                this.amt = amt;
                this.deposit = deposit;
                this.with = with;
                
            }
            public void displaydata()
            {
                Console.WriteLine("CustomerName :" + cn);
                Console.WriteLine("AccountNumber :" + an);
                Console.WriteLine("Amount :" + amt);
                amt = amt + deposit;
                Console.WriteLine("After Deposit Amount : :" + amt);
                amt = amt - with;
                Console.WriteLine(" After Withdrawal Amount :" + amt);
            }
         }
     }
}
