#include<stdio.h>
#include<string.h>
 int main()
 {
 	int cnt=0;
 	char name[10];
 	char*ptr;
 	printf("Enter name");
 	gets(name);
 	ptr=name;
 	while(*ptr!='\0')
 	{
 		if(*ptr=='a' ||*ptr=='e' ||*ptr=='i' ||*ptr=='o' ||*ptr=='u'  )
 		{
 			cnt= cnt+1;
		 }
		 ptr++;
	 }
 
 printf("no of vowel in a string=%d",cnt);
}
 
