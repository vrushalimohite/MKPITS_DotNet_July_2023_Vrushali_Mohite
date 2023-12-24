create table studentss1(rno int ,names varchar(50),city varchar(50))
insert into studentss1(rno,names,city) values
                     (11,'vrushab','nagpur'),
					 (12,'priyu','Akola'),
					 (18,'sujal','pune'),
					 (5,'ritik','mumbai'),
					 (1,'svaraj','nagpur'),
					 (6,'anu','nagpur'),
					 (2,'shivraj','delhi'),
					 (7,'sahil','nagpur');
create procedure s3(@c as varchar(50))
as begin 
select * from students where city=@c end;

exec s3 'nagpur'

