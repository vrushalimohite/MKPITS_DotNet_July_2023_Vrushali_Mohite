create table prizee7(years int ,subject varchar(100),winners_name varchar(100),city varchar(100),country varchar(100))
insert into prizee7 values(1970,' Physics',' Hannes Alfven','Sweden',' Scientist')
insert into prizee7 values(1950,' Physics','Louis Neel ','France ',' Scientist')
insert into prizee7 values(1972,' Chemistry ',' Luis Federico Leloir   ',' France ',' Scientist')
insert into prizee7 values(1970,'Physiology ','  Ulf von Euler ','Sweden',' Scientist')
insert into prizee7 values(1970,' Physiology ','Bernard Katz',' Germany',' Scientist')
insert into prizee7 values(1973,' Literature  ','   Aleksandr Solzhenitsyn   ','  Russia    ','Linguist ')
insert into prizee7 values(1970,' Economics  ','paul Samuelson','USA',' Scientist')
select * from prizee7 where (subject='Physics' and years=1970) Union select * from prizee7 where (subject ='Economics ' and years=1971);