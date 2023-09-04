#include <stdio.h>
int addition(int n1,int n2)
{

int result=n1+n2;
return result;
}
	int main()
	{
	
	char ch='y';
	do
	{
		int num1,num2,result;
		printf("\nenter any 2 number");
		scanf("%d%d",&num1,&num2);
		result= addition(num1,num2);
		printf("\nresult=%d",result);
		printf("\ndo you want to continue ,press y");
		fflush(stdin);
        scanf("%c",&ch);
	}
	while(ch=='y');
	}

