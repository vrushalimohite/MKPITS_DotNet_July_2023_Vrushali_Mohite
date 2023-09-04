#include<stdio.h>
int main()
{
	int n1;
	int n2;
    n1=5;
    n2=2;
    printf("Before Swaping\n");
    printf("n1=%d,n2=%d",n1,n2);
    printf("\nAfter Swaping");
    n1=n1+n2;
    n2=n1-n2;
    n1=n1-n2;
    printf("\nn1=%d,n2=%d",n1,n2);
    
}
