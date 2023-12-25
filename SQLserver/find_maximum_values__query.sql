create table products1211(productname varchar(50),quantity int,years int,price int)
insert into products1211(productname,quantity,years,price)values
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
					  select*from products1211
					  
-----------------------example 1----------------------
select MAX(Quantity)as "maximum quantity" from products1211
-----------------------example 2---------------------
select * from products1211
where quantity=(select max (quantity)
as "maximum quantity" from products1211)
------------------------example 3----------------------
select productname, max (quantity) as "maximum quantity"
from products1211
group by productname


