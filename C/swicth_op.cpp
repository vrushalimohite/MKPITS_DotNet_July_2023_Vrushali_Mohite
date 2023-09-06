#include<stdio.h>
int main()
{
	int num1,num2,result=0;
	char op;
	
	printf("Enter two no\n");
	scanf("%d%d",&num1,&num2);
	printf("Enter op(+,-,*,/) \n");
	fflush(stdin);
	scanf("%c",&op);
	switch(op)
	{
		case'+':
		result=num1+num2;
		break;
		case'-':
		result=num1-num2;
		break;
		case'*':
		result=num1*num2;
		break;
		case'/':
		result=num1/num2;
		break;
    }
		printf("result=%d",result);
						
	
}
