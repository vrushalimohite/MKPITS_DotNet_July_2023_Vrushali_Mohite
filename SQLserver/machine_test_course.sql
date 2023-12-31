create table TableNation(NationID int primary key,NationName varchar(500))
insert into TableNation(NationID ,NationName)values
                        (123,'india'),
						(456,'iran'),
						(789,'sei lanka'),
						(741,'south africa'),
						(852,'nepal'),
						(963,'japan');
select * from TableNation
----------------------------------------------------------------------------
create table TableState(StateID int primary key,
                        NationID int,
						StateName varchar(500),
						foreign key(NationID)references TableNation(NationID) )
insert into TableState (StateID,NationID,StateName)values
                       (789,456,'mahararshtra'),
					   (456,123,'aasam'),
					   (123,789,'kerala'),
					   (963,741,'gujrat'),
					   (852,852,'karnataka'),
					   (741,963,'madhy pradesh');
select * from TableState 
----------------------------------------------------------------------
create table TableCity(CityID int primary key,
                       StateID int,
					   CityName varchar(500)not null,
					   foreign key(StateID )references TableState (StateID) )
insert into TableCity(CityID,StateID,CityNAme)values
                      (11,123,'Nagpur'),
					  (12,963,'Amaravti'),
					  (13,741,'Akola'),
					  (14,852,'Yavatmal'),
					  (15,456,'Katol'),
					  (16,123,'arvi');
 select * from TableCity
 ------------------------------------------------------------------------------
 create table TableCourseRegDetail(CourseRegID int primary key,
                                   Categorylnd int unique,
								   FullName varchar(1500),
								   Genderlnd int )
insert into TableCourseRegDetail(CourseRegID,Categorylnd,FullName,Genderlnd )values
                                (123,12,'vrushali mohite',12),
								(456,13,'sayali kapse',13),
								(789,14,'Mayuri kale',14),
								(741,15,'prita matre',15),
								(852,16,'mrunal gajbye',16),
								(963,17,'pooja kote',18);
select * from TableCourseRegDetail
---------------------------------------------------------------------------------
create table TableRegAddress(RegAddressID int primary key,
                             CourseRegID int ,
							 NationID int,
							 StateID int,
							 CityID int,
							 foreign key(CourseRegID)references TableCourseRegDetail(CourseRegID),
							 foreign key(NationID)references TableNation(NationID),
							 foreign key(StateID )references TableState(StateID),
							 foreign key(CityID)references   TableCity   (CityID))
insert into TableRegAddress(RegAddressID,
                             CourseRegID,
							 NationID,
							 StateID,
							 CityID)values
							 (1,123,456,123,11),
							 (2,456,789,741,12),
							 (3,789,456,852,13),
							 (4,741,852,741,15),
							 (5,852,963,741,16),
							 (6,456,789,123,14);
select * from TableRegAddress
--------------------------------------------------------------------

create table TableFeeDetail(FeeID int primary key,
                            CourseRegID int,
							TotalAmount Decimal,
							Minper decimal,
							PaidAmount Decimal,
							BalAmount Decimal,
							PaidDate DateTime,
							foreign key (CourseRegID)references TableCourseRegDetail(CourseRegID));
insert into TableFeeDetail(FeeID,CourseRegID,TotalAmount,Minper,PaidAmount,BalAmount,PaidDate)values
                          (123,123,550,11,400,150,2023-12-14),       
						  (13,456,500,14,300,200,1001-12-12),
						  (14,789,650,15,500,150,2200-12-07),
						  (15,789,700,116,500,200,2023-05-12),
						  (16,123,800,14,500,300,2022-12-14),
						  (17,852,900,15,500,400,2023-12-15);
select * from  TableFeeDetail


select * from TableNation
select * from TableState 
 select * from TableCity
 select * from  TableCourseRegDetail
 select * from TableRegAddress
 select * from  TableFeeDetail



