#include<iostream>
using namespace std;
	class Employee
	{
		public:
		int empno;
		string empname;
		Employee(int empno,string empname)
		{
			this->empno=empno;
			this->empname=empname;
		}
		void display()
		{
			cout<<empno<<empname;
		}
	};
	int main()
	{
		Employee e1(123,"vrush");
		e1.display();
		return 0;
	}
