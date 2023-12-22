create table students (rno int primary key,
                       names varchar(50),
					   city varchar(50),
					   courseid int);
insert into students (rno,names,city,courseid)values
                      (11,'vrush','nagpur',123),
					  (12,'mayuri','Akola',520),
					  (13,'veera','Amravti',456),
					  (14,'sudha','Nagpur',12365);
select * from students

create table fees(feesid int,
                  rno int,
				  fessdate date,
				  amount int,
				  courseid int,
				  foreign key (rno) references students(rno))
insert into fees(feesid,rno,fessdate,amount,courseid)values
                 (12365,12,'2012-02-11',500,123),
				 (4125,11,'2011-03-08',800,789),
				 (6932,13,'2013-05-11',750,7456),
				 (89654,14,'2015-05-06',450,8965);
select * from fees

-------------------------------subquery-----------------------------

select * from students where rno in(select rno from fees where city='nagpur')
select * from students where rno in(select rno from fees where city='Akola')