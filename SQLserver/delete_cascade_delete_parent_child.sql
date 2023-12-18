create table vendors_group (gvid int primary key identity,name varchar(100))
create table vendors(vendorsid int ,name varchar(10) not null,id int,
                      constraint fk foreign key(id) references vendors_group(gvid) on delete cascade )
   
  insert into vendors_group values('jagu')
 insert into vendors_group values('RAj')

select * from vendors_group
select * from vendors

insert into vendors values(4,'rajesh',1)
insert into vendors values(10,'raj',2)
insert into vendors values(9,'koal',2)
insert into vendors values(5,'chetan',1)
delete from vendors_group where gvid=2

drop table vendors
drop table vendors_group
