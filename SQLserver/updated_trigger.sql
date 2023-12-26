create table employees(empid int primary key,empname varchar(50))
drop table employees
----------------------------create trigger table-----------------------------
create table emplogs(logid int identity,empid int not null,empname varchar(20),operation nvarchar(50)not null,upsateddate datetime not null)
drop table emplogs
create trigger empu2
on employees 
after update
as
insert into emplogs(empid,empname,operation,upsateddate)
select 
empid,empname,'update',getdate()
from deleted;
--------------------------------------
insert into employees values(11,'ravi')
insert into employees values(15,'raj')

select * from employees
select * from emplogs
 update employees set empname='vrush' where empid=15