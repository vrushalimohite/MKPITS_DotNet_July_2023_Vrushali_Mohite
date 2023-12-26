create table department(departmentid int ,departmentname varchar(50),city varchar(20))
insert into department(departmentid,departmentname,city)values
                       (123,'et','nagpur'),
					   (456,'cs','Amravti'),
					   (147,'et','Nagpur'),
					   (963,'cs','Akola'),
					   (9635,'me','yavatmal');
select * from department

create procedure p2(@id as int)
as begin
select * from department
where departmentid =@id
end;

exec p2 147