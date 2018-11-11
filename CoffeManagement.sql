--SQL quan ly quan caphe

--tao bang database 
CREATE DATABASE CoffeManagement
GO

--su dung database da tao la quanlyquancafe
USE CoffeManagement
GO

--tao cac table --

--Tao table tai khoan
CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100)NOT NULL DEFAULT N'Admin',
	PassWord NVARCHAR(100) NOT NULL DEFAULT 0,
	Type INT NOT NULL DEFAULT 0 --loai tai khoan -- 0:Quan ly -- 1:Nhan vien
)
GO
--Tao table ban nuoc
CREATE TABLE TableDrink
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100)NOT NULL DEFAULT N'chua dat ten',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trong' --Status ban trong hoac co nguoi
)
GO

--tao table loai thuc uong
CREATE TABLE TypeDrink
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100)NOT NULL DEFAULT N'chua dat ten'
)
GO

--tao table thuc uong cua loai thuc uong nao
CREATE TABLE drink
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100)NOT NULL DEFAULT N'chua dat ten',
	idTypeDrink INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idTypeDrink) REFERENCES dbo.TypeDrink(id)
)
GO