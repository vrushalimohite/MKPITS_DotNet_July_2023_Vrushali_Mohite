create table TableNationss(NationID int primary key,NationName varchar(500))
insert into TableNationss(NationID,NationName)values
                         (1,'india'),
						 (2,'iran'),
						 (3,'japan'),
						 (4,'gujrat');
select * from TableNationss


create table TableStatess(StateID int primary key,NationID int,StateName varchar(500))
insert into TableStatess(StateID,NationID,StateName)values
                          (11,1,'maarastra'),
						  (12,2,'gujrat'),
						  (13,3,'nepal'),
						  (14,4,'aasam');
select * from TableStatess

create table TableCitys(CityID int primary key,StateID int,CityName varchar(500))
insert into TableCitys values(11,11,'Nagpur')
insert into TableCitys values(12,12,'Amravti')
insert into TableCitys values(13,11,'Akola')
insert into TableCitys values(14,13,'Nagpur')
select * from TableCitys


create table TableCourseRegDetailss(CourseRegID int primary key,Categorylnd int,FullName varchar(500),Genderlnd int)
insert into TableCourseRegDetailss(CourseRegID,Categorylnd,FullName,Genderlnd)values
                                  (1,11,'vrushali mohite',13),
								  (2,11,'sayali kapse',14),
								  (3,11,'mayuri kale',15),
								  (4,11,'prita matre',20);
select * from TableCourseRegDetailss

create table TableRegAddresss(RegAddressID int primary key,
                             CourseRegID int,
							 NationID int,
							 StateID int,
							 CityID int,
							 foreign key (CourseRegID)references TableCourseRegDetailss(CourseRegID),
							  foreign key (NationID)references TableNationss (NationID) ,
							  foreign key (StateID)references TableStatess(StateID),
							   foreign key (CityID)references TableCitys(CityID))

insert into TableRegAddresss values(1,1,1,11,11)
insert into TableRegAddresss values(2,2,1,11,11)
insert into TableRegAddresss values(3,1,3,12,13)
insert into TableRegAddresss values(4,4,3,12,14)
select * from TableRegAddresss


create table TableFeeDetailss(FeeID int primary key,CourseRegID int,TotalAmount int,Minper int,PaidAmount int,BalAmount int,PaidDate datetime)
insert into TableFeeDetailss values(12,1,500,10,400,100,'2023-02-05')
insert into TableFeeDetailss values(13,2,1500,10,500,1000,'2022-02-05')
insert into TableFeeDetailss values(14,1,600,10,400,200,'2027-02-05')
insert into TableFeeDetailss values(15,4,500,10,400,100,'2023-02-05')

select * from TableNationss
select * from TableStatess
select * from TableCitys
select * from TableCourseRegDetailss
select * from TableRegAddresss


select * from TableFeeDetailss

								  

