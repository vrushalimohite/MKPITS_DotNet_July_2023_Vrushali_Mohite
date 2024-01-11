create table TableNation(NationID int primary key,NationName varchar(500))
insert into TableNation(NationID,NationName)values
                       (123,'india'),
					   (456,'south America'),
					    (0,'select');
select * from  TableNation

create table TableState(StateID int primary key,NationID int,StateName varchar(500),foreign key(NationID)references TableNation(NationID ))
insert into TableState(StateID,NationID,StateName)values
                       (1,123,'maharashtra'),
					   (2,123,'madhy pradesh'),
					   (3,456,'nepal');
select * from  TableState

create table TableCity(CityID int primary key,StateID int,CityName varchar(500),foreign key(StateID)references TableState(StateID))

insert into TableCity(CityID,StateID,CityName)values
                     (10,2,'bhopal'),
					 (20,1,'nagpur');
insert into TableCity values(30,3,'Amravti')
select * from TableCity

create table TableCourseRegDetail(CourseRegID int identity primary key,
                                   Categorylnd int,
								   FullName varchar(1500),
								   Genderlnd int )
select * from TableCourseRegDetail
create table TableRegAddress(RegAddressID int identity,
                             CourseRegID int ,
							 NationID int,
							 StateID int,
							 CityID int,
							 foreign key(CourseRegID)references TableCourseRegDetail(CourseRegID),
							 foreign key(NationID)references TableNation(NationID),
							 foreign key(StateID )references TableState(StateID),
							 foreign key(CityID)references   TableCity   (CityID))

select * from TableRegAddress
create table TableFeeDetail(FeeID int identity,
                            CourseRegID int,
							TotalAmount Decimal,
							Minper decimal,
							PaidAmount Decimal,
							BalAmount Decimal,
							PaidDate DateTime,
							foreign key (CourseRegID)references TableCourseRegDetail(CourseRegID));

select * from TableFeeDetail