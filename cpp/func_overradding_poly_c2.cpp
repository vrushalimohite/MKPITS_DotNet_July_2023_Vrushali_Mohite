
#include<iostream>
using namespace std;
class acc
{
	public:
		int accno;
		int bal;
		void deposit(int amt)
		{
			cout<<"Hellow from acc deposit"<<endl;
		}
};
class saving:public acc
{
	public:
		void deposit(int amt)
		{
		
		int intrest=500;
		bal=bal+amt+intrest;
			cout<<"deposit with intrest :"<<bal<<endl;
		}
};
class current:public acc
{
	public:
		void deposit(int amt)
		{
			bal=bal+amt;
			cout<<" deposit without intrest : "<<bal<<endl;
		}
};
int main()
{
	saving s;
	s.accno=12365;
	s.bal=500;
	s.deposit(1000);
	current c;
	c.accno=1254;
	c.bal=500;
	c.deposit(200);
	return 0;
}
