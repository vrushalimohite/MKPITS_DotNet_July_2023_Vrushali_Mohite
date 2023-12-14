create table product(productno int identity,productname varchar(100),Amount bigint)
insert into product values('Book',500)
insert into product values('pen',900)
insert into product values('Book',500)
insert into product values('Bottole',300)
insert into product values('Bag',1500)
insert into product values('pen',500)
select distinct productname from product