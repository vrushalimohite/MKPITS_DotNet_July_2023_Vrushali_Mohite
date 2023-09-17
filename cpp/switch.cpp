//wap add two no using switch statement
#include<iostream>
using namespace std;
int main()
{
	int n1,n2,sum;
	char op;
	cout<<"Enter two no";
	cin>>n1>>n2;
	cout<<"Enter op";
	cin>>op;
	switch (op)
	{
		case '+':
		cout<<n1+n2;
		break;
		
		case '-':
        cout<<n1-n2;
	    break;
	    
	    case '*':
	    cout<<n1*n2;
	    break;
	}
	
}
