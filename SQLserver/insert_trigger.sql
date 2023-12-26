create table employee(empid int primary key,empname varchar(50))

----------------------------create trigger table-----------------------------
create table emplog(logid int identity,empid int not null,operation nvarchar(50)not null,upsateddate datetime not null)

---------------------------The following FOR trigger fires on the INSERT operation on the Employee table.----------
create trigger tri
on employee
for insert
as
insert into emplog(empid,operation,upsateddate)
select 
empid,'insert',getdate()
from inserted;
------------------------insert values in employee table-----------------
insert into employee values(11,'RAM')
insert into employee values(12,'radhe')
select * from employee
select * from emplog
