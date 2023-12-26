create table salary(salary int,empname varchar(50),city varchar(50))
insert into salary (salary,empname,city)values
                   (1000,'payu','Nagpur'),
				   (2500,'vrushali','Amravti'),
				   (50000,'priya','rahatgav'),
				   (25000,'mayuri','nagpur'),
				   (5000,'sahil','nagpur');
  select * from salary 

  create procedure po(@s as int)
  as begin
  select * from salary
  where salary>@s
  end;

  exec po 5000