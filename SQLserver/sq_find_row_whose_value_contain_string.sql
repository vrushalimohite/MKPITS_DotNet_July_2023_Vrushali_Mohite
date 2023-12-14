create table fee (rno int , name varchar(100),course varchar(100),Amount int identity(500,70),paiddate date)
insert into fee values (2,'Vrushali','Dotnet','2023-02-23')
insert into fee values (2,'Mayuri','Dotnet','2023-11-23')
insert into fee values (2,'Mayuri','Dotnet','2023-11-23')
insert into fee values (3,'Ritu','Java','2023-11-2')
insert into fee values (4,'chetan','Dotnet','2023-11-13')
insert into fee  values (5,'priya','java','2023-02-23')
insert into fee values (6,'Vrushali','Dotnet','2023-02-23')
insert into fee values (7,'kunal','Java','2023-11-9')
insert into fee values (8,'Abhii','Dotnet','2023-11-6')
insert into fee values (9,'Vrushali','Dotnet','2023-02-23')
insert into fee values (10,'Vrushali','Dotnet','2023-02-23')
select * from fee where name like '%i%'
select *  from fee where name like '%i'
