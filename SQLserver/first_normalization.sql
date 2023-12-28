create table stud(rollno int primary key,name varchar(50))
insert into stud(rollno,name)values
                 (1,'vrush'),
				 (2,'mayu'),
				 (3,'priya'),
				 (4,'sayali'),
				 (5,'sahil'),
				 (6,'muunal');
create table stud1(rollno int,course varchar(50),foreign key (rollno) references  stud(rollno) )
insert into stud1(rollno,course)values
                  (1,'java'),
				  (2,'dotnet'),
				  (5,'java'),
				  (2,'java'),
				  (1,'charp'),
				  (2,'java'),
				  (2,'css');
select * from stud
select * from stud1 order by rollno