create table products(productid int primary key,productname varchar(50),price int)
insert into products(productid,productname,price) values
                     (123,'tv',500),
					 (654,'mouse',700),
					 (456,'keyboard',550),
					 (852,'pc',900),
					 (741,'printer',456);
select * from products
update  products set price=200
where productname='pc'

update products set productname='new123'
where price=500 and productid=123

update products set productname='new'
where price=55600 or productid=123