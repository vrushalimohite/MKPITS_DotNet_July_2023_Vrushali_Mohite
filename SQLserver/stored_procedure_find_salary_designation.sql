create table employee(salary int,designation varchar(50))
insert into employee (salary,designation)values
                     (100,'clerk'),
					 (10023,'peun'),
					 (100000,'manager'),
					 (10020,'Asistant profesor'),
					 (10000000,'HOD'),
					 (1500,'HR');
select * from employee

create procedure emp(@s as int ,@d varchar(50))
as begin 
select * from employee
where salary>@s and salary<@s
end

exec emp 1000,10000000

create procedure s(@ds as varchar(50))
as begin
select * from employee
where designation=@ds 
end;

exec s 'manager'

