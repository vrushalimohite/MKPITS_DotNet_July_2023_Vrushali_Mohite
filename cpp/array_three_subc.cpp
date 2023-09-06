#include<iostream>
using namespace std;
int main()
{
	int i;
	int sum;
	int marks[3];
	marks[0]=99;
	marks[1]=55;
	marks[2]=82;
	for(i=0;i<3;i++)
		cout<<"Enter the marks\n"<<marks<<endl;
		sum=sum+marks[i];
	cout<<"total marks"<<marks<<sum;
}
