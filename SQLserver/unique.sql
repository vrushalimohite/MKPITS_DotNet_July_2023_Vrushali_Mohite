create table students(rollno int identity primary key,
                      name varchar(100),
                      city varchar (20),
                      groupno varchar(10),
                      unique(groupno))

insert into students values('aboli','Nagpur','A')
insert into students values('abhii','Amravti','D')
insert into students values('sahil','Nagpur','B')
insert into students values('priya','Nagpur','C')
 
 select * from students
