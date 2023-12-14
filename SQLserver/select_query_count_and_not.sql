create table emp (Rollno int , FirstName varchar(100),LastName varchar(100),City varchar(100),State varchar(100))
insert into emp values(1,'Mayuri','Kale','Nagpur','Mah')
insert into emp values(6,'Vrushali','Mohite','Wardha','Mah')
insert into emp values(3,'Sayli','Kapse','Bhandara','Mp')
insert into emp values(5,'Priya','Matre','Amravti','Mp')
insert into emp values(2,'Anuj','Kalmankar','Arvi','Mp')
insert into emp values(7,'Rushi','Sawarkare','Highanghat','Mah')
select * from emp

select FirstName,COUNT (*) from emp where State='Mah' group by FirstName

drop table emp

create table emp1 (Rollno int , FirstName varchar(100),LastName varchar(100),City varchar(100),State varchar(100))
insert into emp1 values(1,'Mayuri','Kale','Nagpur','Mah')
insert into emp1 values(6,'Vrushali','Mohite','Wardha','Mah')
insert into emp1 values(3,'Sayli','Kapse','Bhandara','Mp')
insert into emp1 values(5,'Priya','Matre','Amravti','Mp')
insert into emp1 values(2,'Anuj','Kalmankar','Arvi','Mp')
insert into emp1 values(7,'Rushi','Sawarkare','Highanghat','Mah')
select FirstName,COUNT (*) from emp1 where State<>'Mah' group by FirstName

 
