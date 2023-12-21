create table book(bookno int ,
                  bookname varchar(50),
				  quantity int,
				  price int)
insert into book(bookno,bookname,quantity,price) values
                 (123,'digital electronics',2,450),
				 (654,'electronics',5,500),
				 (789,'analog communication',6,750),
				 (741,'digital communication',9,230),
				 (745,'power electronics',4,600),
				 (951,'communication',1,650);

select * from book


delete from book
where bookname='communication'
