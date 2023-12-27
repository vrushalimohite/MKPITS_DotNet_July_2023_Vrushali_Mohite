create table products2(productid int,productname varchar(50),price int)
  insert into products2(productid,productname,price)values
                      (123,'laptop',1000),
					  (741,'mouse',550),
					  (852,'USB',650),
					  (856,'pen drive',800),
					  (963,'ram',470),
					  (951,'rom',6500);

					  drop table products2

declare @productid int,
        @productname varchar(max),
		@price int;
declare cursors_products2 cursor
for select
productid,
productname,
price from products2
where productname='mouse';

open cursors_products2

fetch next from cursors_products2
into
@productid,
@productname,
@price

while @@fetch_status=0
begin
print cast(@productid as varchar)+@productname+cast(@price as varchar);
fetch next from cursors_products2
into
@productid,
@productname,
@price
end;

close cursor_products2;
deallocate cursor_products2;


