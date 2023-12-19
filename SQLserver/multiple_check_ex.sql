create table product1(productid int identity primary key ,
productname varchar(100),
productprice dec(10,1),
discountprice dec(10,2) ,
  constraint p check( productprice>0 and discountprice>0 and productprice>discountprice));
insert into product1 values('book',400,300)
insert into product1 values('pen',500,100)
insert into product1 values('bottole',400,100)
insert into product1 values('keys',700,300)
select * from product1
drop table product1