create table TableNations(NationID int primary key,NationName varchar(500))
insert into  TableNations(NationID,NationName)values
                        (1,'india'),
						(2,'iran'),
						(3,'japan'),
						(4,'africa');
select * from TableNations


create table TableState(StateID int primary key,NationID int,StateName varchar(500),
foreign key(NationID)references TableNations(NationID))
insert into TableState(StateID,NationID,StateName)values
                      (123,2,'maharashtra'),
					  (456,1,'madhya pradesh'),
					  (789,3,'gujrat'),
					  (741,4,'hariyana');
select * from TableState

create table TableCity(CityID int primary key,StateID int,CityNAme varchar(500),foreign key(StateID)references TableState(StateID) )
insert into TableCity(CityID,StateID,CityName)values
                      (122,123,'Nagpur'),
					  (123,456,'Amravti'),
					  (124,789,'Akola'),
					  (125,741,'YAvatmal');
select * from TableCity

create table TableCourseRegDetails(CourseRegID int primary Key,Categorylnd int,FullName varchar(1500),Genderlnd int)
insert into TableCourseRegDetails(CourseRegID,Categorylnd,FullName,Genderlnd)values
                                  (11,1,'vrushali mohite',1),
								  (12,2,'sayali kapse',2),
								  (13,3,'mayuri kale',3),
								  (14,4,'prita matre',4);

 select * from TableCourseRegDetails

 create table TableRegAddress(RegAddressID int primary key,
                              CourseRegID int,
							  NationID int,
							  StateID int,
							  CityID int,
							  foreign key (CourseRegID)references TableCourseRegDetails (CourseRegID),
							  foreign key (NationID )references TableNations(NationID ),
							  foreign key (StateID)references TableState(StateID),
							  foreign key (CityID)references TableCity(CityID))
insert into TableRegAddress(RegAddressID ,
                              CourseRegID ,
							  NationID ,
							  StateID ,
							  CityID )values
							  (1,11,1,123,122),
							  (3,13,3,789,124),
							  (2,12,2,456,123),
							  (4,14,4,741,125);
select * from TableRegAddress

create table TableFeeDetails(FeeID int primary key,CourseRegID int,TotalAmount int ,Minper int,PaidAmount int,BalanceAmount int,PaidDate Datetime)
insert into TableFeeDetails(FeeID,CourseRegID,	TotalAmount,Minper,PaidAmount,BalanceAmount,PaidDate)values
                            (123,11,550,50,500,50,'2023-02-02'),
							(456,12,400,50,300,100,'2022-02-05'),
							(789,13,700,50,300,500,'2021-03-11'),
							(741,14,500,50,400,100,'2020-04-06');

select * from TableNations
select * from TableState
select * from TableCity
 select * from TableCourseRegDetails


select * from TableRegAddress


select * from TableFeeDetails
     