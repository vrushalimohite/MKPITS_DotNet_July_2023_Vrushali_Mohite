#include<iostream>
using namespace std;
class bank_account
{
	public:
		int accountno;
		int balance=1000;
		int deposit;
		int withdrawl;
		void deposit()
		{
			cout<<"amount deposit"<<endl;
		}
		void withdrawl()
		{
			cout<<"amount withdrawl"<<endl;
		};
		int main()
		{
			int result;
			bank_account b1;
			b1.accountno="123654";
			b1.balance="5000";
			cout<<"accountno"<<b1.accountno<<endl;
			cout<<"balance"<<b1.withdrawl<<endl;
			b1.deposit();
			b1.withdrawl();
			return 0;
		}
}
		

