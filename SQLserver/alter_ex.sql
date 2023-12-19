create table product1(productid int identity primary key ,
productname varchar(100),
productprice int,check (productprice>0),
discountprice dec(10,2),check (discountprice>0),
check (discountprice<productprice))
insert into product1 values('book',400,300)
insert into product1 values('pen',500,100)
insert into product1 values('bottole',400,100)
insert into product1 values('keys',700,300)
select * from product1
alter table product1
add prod int (100)
drop table product1