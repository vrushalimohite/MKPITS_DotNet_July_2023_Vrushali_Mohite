
#include<iostream>
using namespace std;
class rectangle
{
	public:
	int length,width,area,perimeter;
	rectangle()
	{
	
	cout<<"Enter length and width";
	cin>>length>>width;
    area=length*width;
    perimeter=2*length+width;
}
void display()
{

   cout<<"area :"<<area<<endl;
   cout<<"perimeter :"<<perimeter<<endl;
	
}
};
int main()
{
	rectangle r1;
	r1. display();
	return 0;
}

