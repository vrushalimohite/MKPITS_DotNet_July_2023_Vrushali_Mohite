#include<stdio.h>
int main()
{
	int i,n,num[100];
	printf("Enter n");
	scanf("%d",&n);
	//accepting values
	for(i=0;i<n;i++)
	{
		printf("enter num\n");
		scanf("%d",&num[i]);
	}
	for(i=n-1;i>=0;i--)
	{
		printf("\n array is reversed order=%d",num[i]);
	}
}
