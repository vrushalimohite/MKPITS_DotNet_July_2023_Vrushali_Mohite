create table employee(empid int,empname varchar(50),city varchar(50))
insert into employee(empid,empname,city)values
                    (123,'vrushali','nagpur'),
					(456,'mayuri','Wardha'),
					(741,'pragati','Amravti');
select * from employee

create procedure p6
as begin
select count(*) as "total employee count" from employee
end;
exec p6
