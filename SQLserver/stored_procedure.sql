create table products(productno int ,
                      productname varchar(50),
					  years int,
					  listprice int)
insert into products (productno,productname,years,listprice)values
                     (123,'laptop',2012,5000),
					 (456,'printer',2000,80000),
					 (4569,'keyboard',2001,56000),
					 (4152,'mouse',2005,856000),
					 (7894,'headphone',2004,456000),
					 (4569,'pendrive',2007,45000);
select * from products order by productname
drop table products

/*To create a stored procedure that wraps this query, you use the CREATE PROCEDURE statement as follows:*/

create procedure pro1
as begin
select * from products end; 

-------------------------------------find procedure------------------------------
create procedure pro3
as begin
select * from products where years=2000 end;
exec pro3

---------------------------------------executing procedure--------------------------

/* pro1 and pro3 is the name of the stored procedure that you want to execute */

-------------------------------------------modifying stored procedure---------------

alter procedure pro3
as begin
insert into products values(852,'USB',2023,8500)
select * from products
end;

exec pro3

---------------------------------Deleting a stored procedure-----------------------------

drop procedure pro1
exec pro1

----------------------------------Creating a stored procedure with one parameter---------------

create procedure pro4(@minprice as int)
as begin
select * from products
where  listprice>@minprice
end;
exec pro4 7000
exec  pro4 40000

--------------------2---------------------

create procedure pro5(@pi as int)
as begin
select * from products 
where productno>@pi end;

exec pro5 4152

----------3----------

create procedure pro7(@pn as varchar(50))
as begin 
select * from products
where productname=@pn end

exec pro7 'mouse'

--------------------------------stored proc with 2 parameters-------------------------

create procedure pro8(@pn as varchar(50) ,@price as int)
as begin
select * from products
where productname=@pn and listprice>=@price
end;

exec pro8 'mouse',60000

-----------------------------Creating a stored procedure with multiple parameters------------------

create procedure pro9(@min as int ,@max as int)
as begin
select * from products
where listprice>@min and listprice<@max
end;
exec pro9 40000,1000000
exec pro9 @min=45000,@max=1000000

--------------------------------Creating a stored procedure with 3 parameter------------

create procedure pro11(@min as int,@max as int,@pn as varchar(max))
as begin
select * from products
where listprice>@min and listprice<@max and productname=@pn
end;

exec pro11 @min=4000,@max=10000000,@pn='mouse'

create procedure pro13(@min  as int,@max as int ,@pn as varchar(50))
as begin
select * from products
where listprice>@min and listprice<@max and productname like '%' + @pn +'%'
end;

exec pro13 45000,1000000,'mou'
