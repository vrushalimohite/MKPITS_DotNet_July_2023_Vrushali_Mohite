create table orders(ordno int,salesmanid int identity,amount float,orddate date,custid int)
insert into orders values(70001,150.2,'2012-2-12',3005)
insert into orders values(70009,250.2,'2012-5-22',3001)
insert into orders values(7002,65.2,'2012-8-12',3002)
insert into orders values(7004,110.2,'2012-2-18',3009)
select  orddate,salesmanid,ordno,amount from orders
select distinct salesmanid from orders
