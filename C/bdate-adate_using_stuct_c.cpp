#include<stdio.h>
struct student
{
	int rollno;
	char name[20];
	struct date
	{
		int D;
		int M;
		int Y;
		
	}
	bd,ad;
};
int main()
{
	int r;
	struct student a;
	printf("\nEnter students details\n");
	printf("enter roll no");
	scanf("%d",&a.rollno);
	printf("Enter name :");
	scanf("%s",a.name);
	printf("Enter birth date");
	scanf("%d-%d-%d",&a.bd.D,&a.bd.M,&a.bd.Y);
	printf("Enter addmision date:");
	scanf("%d-%d-%d",&a.ad.D,&a.ad.M,&a.ad.Y);
	r=a.ad.Y-a.bd.Y;
	printf("\nAge of student at the time of addmision");
	printf("\t%d year",r);
}
