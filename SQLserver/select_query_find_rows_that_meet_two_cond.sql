create table product1(productno int identity,productname varchar(100),Amount bigint)
insert into product1 values('Book',500)
insert into product1 values('pen',900)
insert into product1 values('Book',500)
insert into product1 values('Bottole',300)
insert into product1 values('Bag',1500)
insert into product1 values('pen',500)
select * from product1 where productname='Book' and Amount=500