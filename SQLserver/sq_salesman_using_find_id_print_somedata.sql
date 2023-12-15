create table salem(salesmanid int ,custid int ,name varchar(100),grade int, city varchar(100))
insert into salem values(4,456,'vrushali',100,'paris')
insert into salem values(5,1456,'mayuri',500,'Nagpur')
insert into salem values(3,84256,'sayli',200,'Dubai')
insert into salem values(6,45536,'mayu',500,'paris')
insert into salem values(8,64564,'vibha',800,'London')
insert into salem values(7,9456,'vrush',400,'gujrat')
insert into salem values(9,7456,'yoga',100,'paris')
insert into salem values(3,9456,'sahi',300,'paris')
insert into salem values(5,1456,'swapnali',1100,'paris')
select * from salem where grade=200 
select name,grade,city from salem where salesmanid=7