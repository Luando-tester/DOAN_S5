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