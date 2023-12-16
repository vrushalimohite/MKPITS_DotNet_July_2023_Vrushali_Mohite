create table prizee4(years int,subject varchar(100),winner_name varchar(100),country varchar(100),category varchar(200))
insert into prizee4 values(1970,' Physics',' Hannes Alfven','Sweden',' Scientist')
insert into prizee4 values(1950,' Physics','Louis Neel ','France ',' Scientist')
insert into prizee4 values(1972,' Chemistry ',' Luis Federico Leloir   ',' France ',' Scientist')
insert into prizee4 values(1970,'Physiology ','  Ulf von Euler ','Sweden',' Scientist')
insert into prizee4 values(1970,' Physiology ','Bernard Katz',' Germany',' Scientist')
insert into prizee4 values(1973,' Literature  ','   Aleksandr Solzhenitsyn   ','  Russia    ','Linguist ')
insert into prizee4 values(1970,' Economics  ','paul Samuelson','USA',' Scientist')
select * from prizee4 where winner_name like '%p%'