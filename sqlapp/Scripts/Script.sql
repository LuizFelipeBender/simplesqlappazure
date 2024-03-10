CREATE TABLE Products
(
ProductID int,
ProductName varchar(1000),
ProductDescription varchar(1000),
Quantity int
)

INSERT INTO Products(ProductID,ProductName,ProductDescription,Quantity) VALUES (1, 'Mobile','ProductDescription', 100)

INSERT INTO Products(ProductID,ProductName,ProductDescription,Quantity) VALUES (2, 'Laptop','ProductDescription', 200)

INSERT INTO Products(ProductID,ProductName,ProductDescription,Quantity) VALUES (3, 'Mouse','ProductDescription', 100)


CREATE TABLE ProductCategory
(
ProductCategoryID int,
ProductCategory varchar(1000)
)

INSERT INTO ProductCategory(ProductCategoryID,ProductCategory) VALUES (1, 'Eletronics')

SELECT * FROM Products 

SELECT * FROM ProductCategory 