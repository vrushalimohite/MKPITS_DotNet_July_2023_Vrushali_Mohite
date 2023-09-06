#include<stdio.h>
int area(int a,int b)
{
	int result=a*b;
	return result;
}
int main()
{
	int a, b,result;
	printf("enter a number");
	scanf("\n%d%d",&a,&b);
	result=area(a,b);
	printf("result=%d",result);

	
}
