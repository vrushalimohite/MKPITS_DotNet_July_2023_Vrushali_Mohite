create table products9(productname varchar(50),quantity int,years int,price int)
insert into products9(productname,quantity,years,price)values
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
					  select*from products9
    SELECT SUM(quantity) AS "sum of quantity"   
    FROM products9;   