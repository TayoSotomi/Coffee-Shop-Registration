--CREATE DATABASE CoffeeDB;
--USE CoffeeDB;

--CREATE TABLE Products(
--	Id INT PRIMARY KEY IDENTITY(1,1),
--	[Name] NVARCHAR(50),
--	[Description] NVARCHAR(200),
--	Price REAL,
--	Category NVARCHAR(50)

--);
SELECT * FROM Products;
--INSERT INTO Products(Name,Description,Price,Category)
--VALUES ('Vanilla', 'Vanilla Latte',2.50,'Latte'),
--('Caramel','Caramel Latte',3,'Latte'),
--('Tea Latte','Spicy rooibos, green jasmine with steamed Milk',3,'Tea'),
--('Chai Latte','Sweet Oregon chai, with steamed milk',3.5,'Tea'),
--('Americano',NuLL,2,'Espresso'),
--('Coffee/Decaf','Locally-roasted organic beans',1.95,'Coffee'),
--('Machiato','Espresso with a dollop of milk',2.40,'Espresso');

--DELETE FROM Products
--WHERE Name IS NULL;