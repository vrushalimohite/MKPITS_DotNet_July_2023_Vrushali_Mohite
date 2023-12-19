create table vendors_group (gvid int primary key identity,name varchar(100))
create table vendors(vendorsid int ,name varchar(10) not null,id int,
                      constraint fk foreign key(id) references vendors_group(gvid) )
   
  insert into vendors_group values('jagu')
 insert into vendors_group values('RAj')

select * from vendors_group
select * from vendors

insert into vendors values(4,'rajesh',1)
insert into vendors values(5,'raj',2)

drop table vendors
drop table vendors_group
