create table fees (rno int , name varchar(100),course varchar(100),Amount int identity(500,70),paiddate date)
insert into fees values (2,'Vrushali','Dotnet','2023-02-23')
insert into fees values (2,'Mayuri','Dotnet','2023-11-23')
insert into fees values (3,'Ritu','Java','2023-11-2')
insert into fees values (4,'chetan','Dotnet','2023-11-13')
insert into fees values (5,'priya','java','2023-02-23')
insert into fees values (6,'Vrushali','Dotnet','2023-02-23')
insert into fees values (7,'kunal','Java','2023-11-9')
insert into fees values (8,'Abhii','Dotnet','2023-11-6')
insert into fees values (9,'Vrushali','Dotnet','2023-02-23')
insert into fees values (10,'Vrushali','Dotnet','2023-02-23')
select * from fees where paiddate BETWEEN '2023-11-1' and '2023-11-30'


