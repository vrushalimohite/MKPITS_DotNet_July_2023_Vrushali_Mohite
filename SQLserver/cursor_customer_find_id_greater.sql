create table customers(customerid int,
                      custname varchar(50),
					  city varchar(50),phoneno int)
insert into customers(customerid,custname,city,phoneno)values
                     (123,'Rajesh','nagpur',123654),
					 (258,'mahesh','Amravti',123654),
					 (2365,'mayuri','Akola',7896541),
					 (7896,'sayali','yavatmal',456987),
					 (7456,'vrushali','Akola',12365478);
declare
@custname varchar(50),
@city varchar(20),
@customerid int;

declare cursor_customers cursor
for select
custname,city,customerid

from customers
where customerid>258;
  
open cursor_customers

fetch next from cursor_customers
into
@custname,
@city,
@customerid;


while @@FETCH_STATUS=0
begin
print @custname + cast(@customerid as varchar)+''+@city;
fetch next from cursor_customers
into
@custname,
@city,
@customerid
end;


close cursor_customers;
deallocate cursor_customers;
