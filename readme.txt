* Create a SQL Database with the query bellow.

CREATE TABLE Products (
productID int IDENTITY(1,1) PRIMARY KEY,
productName varchar(250) NOT NULL,
expiryDate date NOT NULL,
amount varchar(50) NOT NULL,
currency varchar(10) NOT NULL,
isActive varchar(10) NOT NULL
);

* As database changes, Web.config file with the variable named "ProductConnectionString1" must be edited to correct the connection string.