create table employee65(empid int,empname varchar(50),empcontact int,empdepartment varchar(50),empcity varchar(50),salary int )
insert into employee65(empid,empname,empcontact,empdepartment,empcity,salary)values
                    (123,'Ravi',12365478,'electrical','nagpur',10000),
					(456,'Rajesh',12365478,'electronics','Amravti',2000),
					(741,'sayali',14785236,'computer','Akola',55000),
					(789,'Aboli',74125896,'informationtech','pune',8500),
					(456,'harshu',75335775,'mechanical','mumbai',45600),
					(7854,'snehal',78965412,'chemical','yavatmal',46000),
					(7536,'priyal',12365478,'computer','chandrpur',85000),
					(4562,'vrushali',14563278,'electronics','Amravti',95000);
					select * from employee65
create function f2()
returns int
as
begin
return (select * from employee65)
