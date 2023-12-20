create table storess(store_id int primary key,
                   storename varchar(50),
				   phoneno int not null,
				   email varchar(50)unique,
				   street varchar(50)not null,
				   city varchar(50),
				   states varchar(50),
				   zip_code varchar(50) );
insert into storess values(11,'aakash',102233254,'akssh@gmail,com','sadar','nagpur','mah','123655')
insert into storess values(22,'pooja',112233254,'pk@gmail,com','medical square','amravti','mah','223655')
insert into storess values(33,'mayu',2233254,'mk@gmail,com','pardi','akola','mp','523655')
insert into storess values(44,'vrush',89233254,'vm@gmail,com','tukdoji square','yavtamal','mp','523655')
insert into storess values(55,'sayali',92233254,'sayali@gmail,com','zade colony','nagpur','mah','723655')
select * from storess
drop table storess

-----------------------------------------staffs----------------------------------------------

create table staffs(staff_id int  primary key,
                   firstname varchar(100) not null,
				   lastname varchar(100) not null,
				   email varchar(100)unique not null,
				   phone varchar(100),
				   active_days int ,
				   store_id int,  foreign key (store_id) references storess(store_id),
				   managerid int )

insert into staffs values(1,'mitali','rathod','me@gmail.com','123654789',100,11,123)
insert into staffs values(2,'palak','jayswal','pj@gmail.com','7723654789',99,33,334)
insert into staffs values(3,'ravi','rathod','rr@gmail.com','123654789',88,22,800)
insert into staffs values(4,'manthan','jagdale','mj@gmail.com','423654789',77,44,890)
insert into staffs values(5,'bhavesh','ingale','bi@gmail.com','3123654789',88,55,456)

select * from staffs

drop table staffs
-------------------------------------categoriess------------------------------------------

create table categoriess(categories_id int primary key,
                        category_name varchar(50)not null)

insert into categoriess values(5,'car')
insert into categoriess values(4,'bycycle')
insert into categoriess values(3,'two veeler')
insert into categoriess values(2,'bike')
insert into categoriess values(1,'bullet')

select * from  categoriess
drop table  categoriess
--------------------------------------------brands------------------------------------------

create table brandss(brands_id int primary key not null,
                    brand_name varchar(100)not null)

insert into brandss values(99,'maroti')
insert into brandss values(88,'honda')
insert into brandss values(77,'tvs')
insert into brandss values(66,'pulsar')
insert into brandss values(55,'mahindra')

select * from brandss
drop table brands
-------------------------------------------products--------------------------------------------

create table productss(product_id int primary key not null,
                     product_name varchar(100)not null,
					 brand_id int , 
					 foreign key(brand_id) references brandss(brands_id),
					 category_id int, 
					 foreign key (category_id) references categoriess(categories_id) ON DELETE CASCADE ON UPDATE CASCADE,
					 model_year varchar(100),
					 list_price int)
insert into productss values(4,'Book',99,3,'2000',500)
insert into productss values(3,'pen',77,4,'2001',700)
insert into productss values(2,'Book',99,5,'2002',900)
insert into productss values(1,'Bottole',88,2,'2003',500)
insert into productss values(5,'prncil',66,1,'2000',400)
select * from productss
drop table products
-------------------------------------------customers--------------------------------------------

CREATE table customers1(customer_id int primary key,
                             firstname varchar(120)not null,
							 lastname varchar(250)not null,
							 phone_no bigint unique,
							 email varchar(250) not null,
							 street varchar(250) not null,
							 city varchar(250) not null,
							 states varchar(250) not null,
							 zip_code varchar(250)unique not null,)
insert into customers1 values(13,'vishal','jadhav',12365478,'vg@gmail.com','tukdoji putla','Nagpur','mah','1256987')
insert into customers1 values(12,'jay','ingale',22365478,'ji@gmail.com','gandi putla','Akola','mp','9256987')
insert into customers1 values(11,'dhanu','dhumal',312365478,'dd@gmail.com',' ramputla','nagpur','mah','7256987')
insert into customers1 values(14,'pratik','savant',812365478,'ps@gmail.com','medical square','nagpur','mp','2256987')
insert into customers1 values(15,'vrush','mohite',112365478,'vm@gmail.com','tukdoji putla','Amravti','mah','3256987')
select * from  customers1
drop table customers1;
----------------------------------------------orders-------------------------------------------

create table orderss1(orders_id int primary key,
                     customer_id int, 
					 order_status tinyint,
					 order_date date,
					 required_date date,
					 shipped_date date,
					 store_id int,
					 staff_id int,
					 foreign key (customer_id) references customers1(customer_id),
					 foreign key (store_id) references storess(store_id ),
					 foreign key ( staff_id ) references  staffs(staff_id ))

insert into orderss1 values(123,11,1,'2000-02-12','2001-02-11','2002-07-08',11,2)
insert into orderss1 values(133,12,2,'2000-02-12','2001-02-11','2002-07-08',22,1)
insert into orderss1 values(143,14,3,'2000-02-12','2001-02-11','2002-07-08',33,3)
insert into orderss1 values(153,13,4,'2000-02-12','2001-02-11','2002-07-08',44,4)


select * from orderss1
drop table orderss1
-------------------------------------------------orders item-------------------------------

create table items(orders_id int,
                    item_id int primary key,
					product_id int,
					quantity int,
					list_price int,
					discount float,
					foreign key (orders_id) references orderss1(orders_id),
					foreign key (product_id) references productss(product_id))
insert into items values(123,5,1,10,500,25)
insert into items values(133,6,2,10,700,25)
insert into items values(143,7,4,10,800,25)
insert into items values(153,8,3,10,900,25)
select * from items
-------------------------------------------------stocks------------------------------------
create table stocks(store_id int,
                    product_id int,
					quantity int not null,
					foreign key (product_id ) references productss(product_id),
					foreign key (store_id ) references storess(store_id));
insert into stocks values (22,4,2)
insert into stocks values (33,1,10)
insert into stocks values (22,3,200)
insert into stocks values (44,2,50)
insert into stocks values (55,4,56)
select * from stocks
drop table stocks




select * from storess
select * from staffs
select * from  categoriess
select * from brandss
select * from productss
select * from  customers1
select * from orderss1
select * from items
select * from stocks
