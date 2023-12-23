create table custmer1 (customerid int primary key,
                       customername varchar(50),
					   city varchar(50),
					   state varchar(50))
insert into custmer1(customerid,customername,city,state)values
                    (123,'Rajesh','nagpur','mah'),
					(456,'Ramesh','Amravati','mp'),
					(789,'kajal','Akola','mp'),
					(741,'sahil','nagpur','mah');
select * from custmer1

create table orders(odid int ,
                    city varchar(50),
					customerid int , 
					foreign key(customerid) references custmer1(customerid) )
insert into orders values(123,'nagpur',123)
insert into orders values(456,'Amravti',456)
select *  from orders
--------------------------inner join---------------------
select * from custmer1
inner join orders
on orders.customerid=custmer1.customerid

