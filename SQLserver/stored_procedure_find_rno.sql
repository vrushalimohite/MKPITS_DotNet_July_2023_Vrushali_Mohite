create table studentss2(rno int ,names varchar(50),city varchar(50))
insert into studentss2(rno,names,city) values
                     (11,'vrushab','nagpur'),
					 (12,'priyu','Akola'),
					 (18,'sujal','pune'),
					 (5,'ritik','mumbai'),
					 (1,'svaraj','nagpur'),
					 (6,'anu','nagpur'),
					 (2,'shivraj','delhi'),
					 (7,'sahil','nagpur');
select * from studentss2
------------------------stored procedure find rno------------------------
create procedure ps1 (@rn as int)
as begin
select * from studentss2 where rno>@rn 
end;
exec ps1 3

create procedure ps3 (@rn as int, @rn1 as int)
as begin
select * from studentss2 where rno>@rn and rno<@rn1
end;

exec ps3 3,15

