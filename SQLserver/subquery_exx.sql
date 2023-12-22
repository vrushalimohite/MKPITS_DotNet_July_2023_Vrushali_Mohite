create table stut(feesid int,
                  rno int,
				  fessdate date,
				  amount int,
				  courseid int primary key)
insert into stut(feesid,rno,fessdate,amount,courseid)values
                 (12365,12,'2012-02-11',500,123),
				 (4125,11,'2011-03-08',800,789),
				 (6932,13,'2013-05-11',750,7456),
				 (89654,14,'2015-05-06',450,8965);
select * from stut

create table course(courseid int ,
                    coursename varchar(50),
					fees int,
					foreign key(courseid) references stut(courseid))
insert into course(courseid,coursename,fees)values
                   (789,'java',5000),
				   (123,'dotnet',40000),
				   (7456,'java',80000),
				   (8965,'java',4600);
select * from course where coursename='java'

------------------------------subquery----------------------------------

select * from stut where courseid in(select courseid from course where coursename='java')