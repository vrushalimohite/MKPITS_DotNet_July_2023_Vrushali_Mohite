create table class(rollno int identity ,name varchar(100),secssion varchar(100))
insert into class values('vrush','A')
insert into class values('mayu','C')
insert into class values('Sayali','D')
insert into class values('Mrunal','E')
insert into class values('Trish','A')
insert into class values('Priya','g')
select top 2 rollno,name,secssion from class order by name

create table class1(rollno int identity ,name varchar(100),secssion varchar(100))
insert into class1 values('vrush','A')
insert into class1 values('mayu','C')
insert into class1 values('Sayali','D')
insert into class1 values('Mrunal','E')
insert into class1 values('Trish','A')
insert into class1 values('Priya','g')
select Top 80 Percent rollno,name,secssion from class1 order by name