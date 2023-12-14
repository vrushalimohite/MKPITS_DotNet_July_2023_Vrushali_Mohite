create table product3(productno int identity,productname varchar(100),Amount bigint)
insert into product3 values('Book',500)
insert into product3 values('pen',900)
insert into product3 values('Book',500)
insert into product3 values('Bottole',300)
insert into product3 values('Bag',1500)
insert into product3 values('pen',500)
select * from product3 where Amount>500 or productname='pen'