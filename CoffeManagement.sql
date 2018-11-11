--SQL quan ly quan caphe


-- Lai -- 
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

-- End -- 

-- Luan -- 
--Tao table ban nuoc
CREATE TABLE TableDrink
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100)NOT NULL DEFAULT N'chua dat ten',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trong' --Status ban trong hoac co nguoi
)
GO

-- END -- 

-- Nguyen -- 
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

-- END -- 

-- Truc -- 
--tao table hoa don ban

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn Date NOT NULL DEFAULT GETDATE(),
	DateCheckOut Date NOT NULL,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0 --0:chua thanh toan , 1: da thanh toan
	
	FOREIGN KEY (idTable) REFERENCES dbo.TableDrink(id)
)
GO

--tao table bao cao hoa don 
CREATE TABLE DrinkBill
(  
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idDrink INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idDrink) REFERENCES dbo.Drink(id)
)
GO

-- END -- 