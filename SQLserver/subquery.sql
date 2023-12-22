create table customers(customerid int primary key,
                       firstname varchar(50),
					   lastname varchar(50),
					   phone_no int,
					   email varchar(100),
					   street  varchar(50),
					   city varchar(50),
					   states varchar(50),
					   zipcode int)
insert into customers (customerid,firstname,lastname,phone_no,email,street,city,states,zipcode)values
                       (123,'nehal','sharma',12365478,'ns@gmail.com','bhagavan square','nagpur','mp',123654),
					   (456,'sujal','gayki',123987456,'sg@gmail.com','tikdoji square','Amravti','mah',456987),
					   (789,'priyal','Agnhotri',123685214,'pa@gmail.com','ram nagar','nagpur','mah',74125),
					   (741,'kanchan','rathi',458296314,'kr@gmail.com','arvi naka','akola','mp',154564),
					   (852,'david','rathi',459871255,'dr@gmail.Com','ram nagar','yavatmal','mah',123658);

select * from customers
drop table customers

create table orders(orderid int,
                    order_status int,
					customerid int ,
					foreign key(customerid) references customers(customerid),
					staffid int )
insert into orders(orderid,order_status,customerid,staffid)values
                    (145,1,456,78),
					(471,2,123,78),
					(478,1,789,78),
					(753,4,741,78);
select * from orders


------------------------------subquery------------------------------------------
select * from orders where customerid in(select customerid from customers where city='nagpur')



