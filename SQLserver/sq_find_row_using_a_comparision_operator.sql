create table product2(productno int identity,productname varchar(100),Amount bigint)
insert into product2 values('Book',500)
insert into product2 values('pen',900)
insert into product2 values('Book',500)
insert into product2 values('Bottole',300)
insert into product2 values('Bag',1500)
insert into product2 values('pen',500)
select * from product2 where Amount>500 and productname='Bag'