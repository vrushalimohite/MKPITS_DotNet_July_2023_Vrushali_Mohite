create table staff(staffid int primary key ,
                   staffage int not null,
				   name varchar(50) not null unique,
				   city varchar(50))
insert into staff(staffid,staffage,name,city)values
                  (11,50,'vrushali','nagpur'),
				  (12,55,'mayuri','Nagpur'),
				  (13,57,'sayali','Amravti'),
				  (14,60,'priya','yavatmal'),
				  (15,65,'kajal','Akola'),
				  (17,70,'yoga','katol');

create table staff2(staffid int not null,
                    course varchar(50),
					foreign key(staffid)references staff(staffid))
insert into staff2(staffid,course)values
                   (12,'java'),
				   (12,'dotnet'),
				   (11,'java'),
				   (13,'csharp'),
				   (17,'css'),
				   (11,'html'),
				   (14,'java'),
				   (13,'c');
select * from staff
select * from staff2