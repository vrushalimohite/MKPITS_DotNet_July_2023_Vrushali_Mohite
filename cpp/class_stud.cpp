#include<iostream>
using namespace std;
class students
{
	public:
		string name;
		string course;
		int rollno;
		void getdata()
		{
			cout<<"Enter rollno,name,course"<<endl;
			cin>>rollno>>name>>course;
		}
		void displaydata()
		{
			cout<<"rollno :"<<rollno<<endl;
			cout<<"name :"<<name<<endl;
			cout<<"course :"<<course<<endl;
			cout<<"-----------------"<<endl;
		
		}
	};
		int main()
		{
			students stud1,stud2;
			cout<<"student1"<<endl;
			stud1.getdata();
			stud1.displaydata();
			cout<<"student2"<<endl;
			stud2.getdata();
		    stud2.displaydata();
			return 0;
		
	}
