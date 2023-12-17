 create table users1(age int identity,name varchar(100),address varchar(100)not null,id int primary key)
 insert into users1 values('sagar','nagpur',123654)
  insert into users1 values('yoga','Wardha',1254) 
  insert into users1 values('jigu','Arvi',13654)
   insert into users1 values('sagar','nagpur',1236454)
    insert into users1 values('sagar','nagpur',1236654)
	select distinct name from users1 