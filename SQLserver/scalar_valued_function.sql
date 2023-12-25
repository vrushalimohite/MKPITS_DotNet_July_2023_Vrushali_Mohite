create table stud_info(rno int,m1 int,m2 int,m3 int)
insert into stud_info values(1,20,30,40)
insert into stud_info values(2,50,60,70)
select * from stud_info

create function fun1(@m1 int,@m2 int,@m3 int)
returns int
as
begin
return (select (@m1+@m2+@m3))
end

select dbo.fun1(m1,m2,m3) as 'total' from stud_info