create table salesman(salesmanid int,name varchar(100),city varchar(100),commission float)
insert into salesman values(5001 , 'James Hoog', ' New York', 0.15)
insert into salesman values(5002, 'Nail Knite ', 'Paris     ', 0.13)
insert into salesman values(5005 , 'Pit Alex', 'London' ,0.11)
insert into salesman values(5006 , 'Mc Lyon', 'Paris', 0.14)
insert into salesman values(5007 , 'Paul Adam'  , ' Rome ', 0.13)
insert into salesman values(5003 , 'Lauson Hen ', ' San Jose ', 0.12)
select * from salesman
select name,commission from salesman