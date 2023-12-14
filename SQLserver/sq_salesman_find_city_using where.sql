create table orders1(ordno int,city varchar(100),salesmanid int identity,amount float,orddate date,custid int)
insert into orders1 values(70001,'paris',150.2,'2012-2-12',3005)
insert into orders1 values(70009,'London ',250.2,'2012-5-22',3001)
insert into orders1 values(7002,'paris',65.2,'2012-8-12',3002)
insert into orders1 values(7004,'Rome  ',110.2,'2012-2-18',3009)
select ordno,city from orders1 where city='paris' 
