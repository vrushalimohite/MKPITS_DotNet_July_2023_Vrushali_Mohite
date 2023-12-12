create table employee (empid int identity(1,1),empname varchar(100))
insert into employee (empname) values ('Ram')
insert into employee (empname) values ('prachi')
insert into employee (empname) values ('kalu')
insert into employee (empname) values ('mayu')
insert into employee (empname) values ('kajal')
select * from employee
insert into employee (empname) values ('uayu')
delete from employee where empid=3
select * from employee