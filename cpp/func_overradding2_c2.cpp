#include<iostream>
using namespace std;
class acc
{
	public:
		int accno;
		int bal;
	virtual	void deposit(int amt)
		{
			cout<<"hello from deposit acc"<<bal<<endl;
		}
};
class saving:public acc
{
	public:
		void deposit(int amt){
			int intrest=500;
			bal=bal+amt+intrest;
			cout<<"bal with intrest"<<bal<<endl;
		}
};
class current:public acc
{
	public:
		void deposit(int amt)
		{
		
		bal=bal+amt;
		cout<<"bal without intrest"<<bal<<endl;
}
};
int main()
{
	acc *acc;
	saving s;
	current c;
	acc=&s;
	acc->accno=45;
	acc->bal=500;
	acc->deposit(400);
	acc=&c;
	acc->accno=1236;
	acc->bal=500;
	acc->deposit(200);
	return 0;
}
