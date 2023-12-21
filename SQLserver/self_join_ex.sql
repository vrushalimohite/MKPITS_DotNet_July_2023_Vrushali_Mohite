create table emp(id int,name varchar(50),m_id int)
insert into emp (id,name,m_id) values
                (101,'raj',103),
				(102,'Rajesh',104),
				(103,'mayu',null),
				(104,'vrush',103);
select a.name as managerid,b.name
from emp a
join emp b
on a.id=b.m_id;


