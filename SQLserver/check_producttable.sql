create table product(productid int identity primary key
,prroductname varchar(100),
productprice dec(10,3),check (productprice>0))
insert into product values ('Ram',100)
insert into product values('sham',800)
insert into product values('komal',0)
insert into product values('sham',800)


select * from product