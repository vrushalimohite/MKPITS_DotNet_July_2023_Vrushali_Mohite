#include<stdio.h>
int main()
{
	int i;
	int sum=0;
	int marks[5];
	for(i=0;i<5;i++)
	{
		printf("\n Enter marks");
		scanf("%d",&marks[i]);
	}
	for(i=0;i<5;i++)
	{
		printf(" \n Marks= %d",marks[i]);
		sum=sum+marks[i];
		
	}
	printf("\ntotalmarks = %d",sum);
		
	}

