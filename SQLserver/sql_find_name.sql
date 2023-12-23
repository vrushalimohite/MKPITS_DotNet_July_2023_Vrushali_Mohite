create table prize1(years int,subject varchar(100),winner_name varchar(100),country varchar(100),category varchar(200))
insert into prize1 values(1970,' Physics',' Hannes Alfven','Sweden',' Scientist')
insert into prize1 values(1950,' Physics','  Louis Neel ','France ',' Scientist')
insert into prize1 values(1972,' Chemistry ',' Luis Federico Leloir   ',' France ',' Scientist')
insert into prize1 values(1970,'Physiology ','  Ulf von Euler ','Sweden',' Scientist')
insert into prize1 values(1970,' Physiology ','Bernard Katz',' Germany',' Scientist')
insert into prize1 values(1973,' Literature  ','   Aleksandr Solzhenitsyn   ','  Russia    ','Linguist ')
insert into prize1 values(1970,' Economics  ',' Paul Samuelson ','USA',' Scientist')
select years,subject,winner_name  from prize where years=1970 

select winner_name from prize where subject='Literature' and years=1973
select years,subject from prize where winner_name='Bernard Katz'
select winner_name from prize where years=1950 
drop table prize








                                             
                           
