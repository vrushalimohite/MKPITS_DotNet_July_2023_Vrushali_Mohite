#include<stdio.h>
int main()
{
	void foo(),f();
	f();
	
}
void foo()
{
	printf("2");
	
}
void f()
{
	printf("/"); foo();
}
	
