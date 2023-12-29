create table TableProductsGSTDetails(Product_Gst_ID int primary key,Gst_Detail_Name varchar(500),CGST DECIMAL,SGST DECIMAL,IGST DECIMAL)
INSERT into TableProductsGSTDetails(Product_Gst_ID,Gst_Detail_Name,CGST,SGST,IGST)values
                                   (11,'printer',10,11,12),
								   (12,'mouse',10,11,12),
								   (13,'keyboard',10,11,12);
select * from TableProductsGSTDetails
-------------------------------------------------------------------------------

create table TableProductCategory(Product_Category_ID int primary key,
                                  Product_type_name varchar(500),
								  Product_GST_ID int ,
								  foreign key (Product_GST_ID)references TableProductsGSTDetails(Product_Gst_ID))
insert into  TableProductCategory(Product_Category_ID,Product_type_name, Product_GST_ID)values
                                  (11,'USB',11),
								  (12,'RAM',12),
								  (13,'ROM',11);
select * from TableProductCategory
----------------------------------------------------------------------

create table TableProduct(ProductID int primary key,
                          ProductTypeID int,
						  ProductName varchar(500))
insert into TableProduct(ProductID, ProductTypeID, ProductName)values
                         (1,123,'mouse'),
						 (2,456,'keyboard'),
						 (3,789,'pen drive');
select * from TableProduct

-----------------------------------------------------------------------

create table TableInvoiceDetails(Invoice_Detail_ID int primary key,
                                 Customer_Name varchar(500),
								 Customer_Contact varchar(15),
								 Product_Category_ID int,
								 Product_ID int,
								 Residential_Type_ID int,
								 Invoice_Date datetime,
								 Quantity Decimal,
								 Price Decimal,
								 CGST decimal,
								 SGST decimal,
								 IGST decimal,
								 CGST_value decimal,
								 SGST_value decimal,
								 IGST_value decimal,
								 TotalAmount decimal,
								 foreign key(Product_Category_ID)references TableProductCategory(Product_Category_ID),
								 foreign key(Product_ID)references TableProduct(ProductID));

insert into TableInvoiceDetails(Invoice_Detail_ID, Customer_Name,Customer_Contact,Product_Category_ID , Product_ID,Residential_Type_ID,Invoice_Date, Quantity,Price,CGST,SGST,IGST,CGST_value,SGST_value,IGST_value,TotalAmount)	values							 

                                (11,'vrushali',123654,11,1,12,'2023-01-11',2,550,10,20,60,40,10,320,1000),
								(12,'mayuri',789654,12,2,12,'2022-02-03',3,650,10,20,60,40,10,560,1700);

select * from TableProductCategory
select * from TableProduct

select * from TableInvoiceDetails