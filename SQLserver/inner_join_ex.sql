create table students(id int primary key,name varchar(100) not null)
insert into students(id,name) values
                    (101,'Pankhude'),
					(102,'aanad'),
					(103,'mahima');
select * from students
----------------------------tabel2---------------------------------
create table course(id int primary key,course varchar (50)not null,city varchar(20))
insert into course(id,course,city) values
                   (105,'amit','nagpur'),
				   (101,'vishal','Amravti'),
				   (103,'anju','Akola'),
				   (102,'manjiri','mumbai'),
				   (107,'manju','pune');
select * from course

/*ineer join*/

select *
from students
inner join course
on students.id=course.id;