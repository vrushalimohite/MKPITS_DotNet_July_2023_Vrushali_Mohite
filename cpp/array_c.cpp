#include<iostream>
using namespace std;
int main()
{
	int i;
	int sum=0;
	int marks[3];
	cout<<"enter the marks";
	for(i=0;i<3;i++)
	{
		cin>>marks[i];
		sum=sum+marks[i];
	}
	cout<<"total marks"<<sum;
}
