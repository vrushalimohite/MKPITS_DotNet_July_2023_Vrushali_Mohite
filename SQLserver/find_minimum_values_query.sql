create table products121(productname varchar(50),quantity int,years int,price int)
insert into products121(productname,quantity,years,price)values
                      ('Book',4,2010,500),
					  ('Pen',2,2000,550),
					  ('Bottle',1,2010,1000),
					  ('printer',3,1021,550),
					  ('laptop',1,2023,45600),
					  ('mouse',7,2002,45600),
					  ('keyboard',1,2003,7000),
					  ('printer',4,2001,5500),
					  ('pen drive',2,2003,4500),
					  ('hard disk',6,2005,85600);
					  select*from products121
					  drop table products121
-----------------------example 1----------------------
select MIN(Quantity)as "minimum quantity" from products121
------------------------example 2---------------------
select * from products121
where quantity=(select min (quantity)
as "minimum quantity" from products121)
------------------------example 3--------------------
select productname, min (quantity) as "minimum quantity"
from products121
group by productname
--------------------------example 4------------------
select productname,min(quantity)as "Minimum quantity"
from products121
group by productname
having min(Quantity)>2;