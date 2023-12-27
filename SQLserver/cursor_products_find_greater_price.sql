create table products1(productid int,productname varchar(50),price int)
  insert into products1(productid,productname,price)values
                      (123,'laptop',1000),
					  (741,'mouse',550),
					  (852,'USB',650),
					  (856,'pen drive',800),
					  (963,'ram',470),
					  (951,'rom',6500);

declare @productid int,
        @productname varchar(max),
		@price varchar(max);

declare cursor_products1 cursor
for select
productid,
productname,
price
from products1
where price>470;

open cursor_products1

fetch next from cursor_products1
into
@productid,
@productname,
@price;

while @@FETCH_STATUS=0

begin
print cast(@productid as varchar)+@productname+cast(@price as varchar);
fetch next from cursor_products1
into 
@productid,
@productname,
@price
end;

close cursor_products1;
deallocate cursor_products1;




