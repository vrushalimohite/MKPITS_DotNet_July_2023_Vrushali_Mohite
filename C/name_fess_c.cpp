#include<stdio.h>
#include<string.h>
struct student
{
	char name[5];
    int fees;
    int r;
};
int main()
{
	int r,p=0;
	struct student s1;
	strcpy(s1.name,"manthan");
	s1.fees=65000;
	printf("\nMKP students name= % s",s1.name);
	printf("\nsix month fees0= %d",s1.fees);
	r=25*6;                                          //25day*six month
	printf("\n total day in six month :");
	printf("%d",r);
	p=r/65000;
	printf("\n per day fees :");
	printf("%d",&p);
	
}
    
