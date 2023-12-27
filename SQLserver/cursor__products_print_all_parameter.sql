create table products(productid int,productname varchar(50),price int)
  insert into products(productid,productname,price)values
                      (123,'laptop',1000),
					  (741,'mouse',550),
					  (852,'USB',650),
					  (856,'pen drive',800),
					  (963,'ram',470),
					  (951,'rom',6500);
drop table products
declare @productid int,
       @productname varchar(20),
	   @price int;

declare cursor_products cursor
for select
productid,
productname,
price from products;

open cursor_products;

fetch next from cursor_products 
into
@productid,
@productname,
@price;

while @@FETCH_STATUS=0
begin
print cast(@productid as varchar)+ @productname+cast(@price as varchar);
fetch  next from cursor_products
into
@productid,
@productname,
@price
end;

 close cursor_products;
 deallocate cursor_products;






					  