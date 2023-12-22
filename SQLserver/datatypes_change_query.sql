create table pen(penid int,penprice int,quantity int,price int)
insert into pen(penid,penprice,quantity,price)values
                (123,20,1,50),
				(456,20,2,100),
				(789,20,3,150),
				(741,20,5,250);
select * from pen

alter table pen
alter column price dec(10,2)