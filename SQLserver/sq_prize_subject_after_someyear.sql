create table prizee2(years int,subject varchar(100),winner_name varchar(100),country varchar(100),category varchar(200))
insert into prizee2 values(1970,' Physics',' Hannes Alfven','Sweden',' Scientist')
insert into prizee2 values(1950,' Physics','  Louis Neel ','France ',' Scientist')
insert into prizee2 values(1972,' Chemistry ',' Luis Federico Leloir   ',' France ',' Scientist')
insert into prizee2 values(1970,'Physiology ','  Ulf von Euler ','Sweden',' Scientist')
insert into prizee2 values(1970,' Physiology ','Bernard Katz',' Germany',' Scientist')
insert into prizee2 values(1973,' Literature  ','   Aleksandr Solzhenitsyn   ','  Russia    ','Linguist ')
insert into prizee2 values(1970,' Economics  ',' Paul Samuelson ','USA',' Scientist')
select winner_name from prizee2 where subject='Physics'or years>1972