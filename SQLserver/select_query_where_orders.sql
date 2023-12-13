create table Customer1 (Rollno int , FirstName varchar(100),LastName varchar(100),City varchar(100),State varchar(100))
insert into Customer1 values(1,'Mayuri','Kale','Nagpur','Mah')
insert into Customer1 values(6,'Vrushali','Mohite','Wardha','Mah')
insert into Customer1 values(3,'Sayli','Kapse','Bhandara','Mp')
insert into Customer1 values(5,'Priya','Matre','Amravti','Mp')
insert into Customer1 values(2,'Anuj','Kalmankar','Arvi','Mp')
insert into Customer1 values(7,'Rushi','Sawarkare','Highanghat','Mah')
select * from Customer1 where state='mah' order by FirstName

create table Customer2 (Rollno int , FirstName varchar(100),LastName varchar(100),City varchar(100),State varchar(100))
insert into Customer2 values(1,'Mayuri','Kale','Nagpur','Mah')
insert into Customer2 values(6,'Vrushali','Mohite','Wardha','Mah')
insert into Customer2 values(3,'Sayli','Kapse','Bhandara','Mp')
insert into Customer2 values(5,'Priya','Matre','Amravti','Mp')
insert into Customer2 values(2,'Anuj','Kalmankar','Arvi','Mp')
insert into Customer2 values(7,'Rushi','Sawarkare','Highanghat','Mah')
select * from Customer2 where state='mah' 