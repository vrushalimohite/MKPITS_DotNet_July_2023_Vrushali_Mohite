#include<stdio.h>
struct customer
{
	char Name[50];
	int accountno;
	int balance;
};
int main
{
	struct customer c[5];
	int counter;
	for(counter=0;counter<3;counter++)
	{
		printf("Name :");
		scanf("%s",&c[counter].Name);
		printf("accountno :");
		scanf("%d",&c[counter].accountno);
		printf("Bank balance :");
		scanf("%d",&c[counter].balance);
	}
}
