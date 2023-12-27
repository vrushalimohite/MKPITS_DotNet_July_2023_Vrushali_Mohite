create table product(productname varchar(50),
                     id int primary key,
					 list_price int not null,
					 brand_id int,
					 model_year int)
insert into product(productname,id,list_price,brand_id,model_year)values
                    ('laptop',123,550,741,2001),
					('mouse',456,1000,741,2002),
					('keyboard',789,1500,741,2022),
					('usb',741,450,741,2023);
declare @productname varchar(max),
@list_price int;
declare cursorp1 cursor
for select
productname,
list_price
from
product;

open cursorp1
fetch next from cursorp1
into 
@productname,@list_price;
 print @productname+cast(@list_price as varchar); 
 while @@FETCH_STATUS=0
 begin
 fetch next from cursorp1
 into 
 @productname,@list_price;
 print @productname+cast(@list_price as varchar)
 end;
 close cursorp1
 deallocate cursorp1;

