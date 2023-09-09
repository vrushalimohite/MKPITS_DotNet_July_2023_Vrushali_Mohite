#include<stdio.h>
int main()
{
	int a=2, b=3, c=5, v;
	
	a++;
	b++;
	++c;
	v=a++ + b++ + ++c;
	printf("result is :%d",v);
	
	
}
