create table customer(custid int primary key,
                      custname varchar(50)not null,
					  mono varchar(50)not null)

insert into customer(custid,custname,mono)values
                    (123,'Rajesh','12365478'),
					(456,'mrunal','123654789'),
					(789,'sayali','78965412');
select * from customer
drop table customer
-----------------------------tabel 2 (orders)-----------------------------
create table orders(orderid int,
                    orderdate date,
					custid int,
					productname varchar(50),
					Quntity int,
					Price int)
insert into orders(orderid,orderdate,custid,productname,Quntity,price) values
                   (4560,'2021-02-12',456,'Book',2,500),
				   (12365,'2012-02-03',215,'bottole',3,300),
				   (14789,'2000-03-07',789,'pencil',2,800);
select * from orders
drop table orders
---------------------------left join query--------------------------
select * 
from orders as o
left join customer as c
on c.custid=o.custid order by custname;

