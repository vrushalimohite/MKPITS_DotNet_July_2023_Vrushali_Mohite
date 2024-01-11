create table TableProductGSTDetails(Product_GST_ID int primary key,GST_Detail_Name varchar(500),CGST DECIMAL,SGST DECIMAL,IGST DECIMAL)
INSERT INTO TableProductGSTDetails values(10,'LAPTOP',9,9,9)
INSERT INTO TableProductGSTDetails values(20,'MOABIL',14,14,14)
INSERT INTO TableProductGSTDetails values(30,'TV',9,9,9)
INSERT INTO TableProductGSTDetails values(40,'SMART WATCH',6,6,6)
SELECT * FROM TableProductGSTDetails 




create table TableProductCategorys (Product_Category_ID int primary key,product_Type_Name varchar(500),Product_Gst_ID int,FOREIGN KEY (Product_Gst_ID)REFERENCES TableProductGSTDetails 
(Product_GST_ID) )
insert into TableProductCategorys values(1,'LAPTOP',10)
insert into TableProductCategorys values(2,'MOBAIL',20)
insert into TableProductCategorys values(3,'TV',30)
insert into TableProductCategorys values(4,'SMART WATCH',40)
Select * from TableProductCategorys

drop table TableProductCategory


 create table TableProduct(productID int primary key,
                           Product_Category_ID int,
						   Product_Name varchar(500),
						   price int,
						   foreign key (Product_Category_ID )references TableProductCategorys (Product_Category_ID ))
 INSERT INTO TableProduct VALUES(100,1,'HP',1000)
  INSERT INTO TableProduct VALUES(101,1,'acer',2000)
 INSERT INTO TableProduct VALUES(102,2,'Realme',5500)
 INSERT INTO TableProduct VALUES(103,2,'Redmi',65000)
 INSERT INTO TableProduct VALUES(104,2,'Apple',10000)
 INSERT INTO TableProduct VALUES(105,3,'Samsung',11000)
 INSERT INTO TableProduct VALUES(106,3,'MI',150000)
 INSERT INTO TableProduct VALUES(107,3,'Asus',18000)
 INSERT INTO TableProduct VALUES(108,4,'Noise',1000)
 INSERT INTO TableProduct VALUES(109,4,'Boat',5000)
 select * from TableProduct




