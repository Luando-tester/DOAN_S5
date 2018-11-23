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

INSERT INTO dbo.Account(UserName,DisplayName,PassWord,Type)
VALUES(N'Admin',N'Admin',N'1',0)
GO

CREATE PROC SP_Ban
AS SELECT * FROM dbo.TableDrink
GO

EXEC SP_Ban

GO

--Them ban
CREATE PROC SP_themBan(@name NVARCHAR(100),@status NVARCHAR(100))
AS
BEGIN
	INSERT INTO TableDrink(name,status)
	VALUES(@name,@status)
END

EXEC SP_themBan N'ban 1','trong'

GO
--Cap nhat ban
CREATE PROC SP_capnhatBan(@id INT,@name NVARCHAR(100),@status NVARCHAR(100))
AS
BEGIN
	UPDATE TableDrink
	SET name = @name,status = @status
	WHERE id = @id
END
GO

EXEC SP_capnhatBan 1,N'ban2','co nguoi'
GO

--Delete ban
CREATE PROC SP_xoaBan(@id INT)
AS
BEGIN
	DELETE FROM TableDrink
	WHERE id = @id
END
GO

EXEC SP_xoaBan 1
GO


-- lay danh sach tai khoan
CREATE PROC SP_Account
AS SELECT *FROM dbo.Account
GO
EXEC SP_Account
GO

--them tai khoan
CREATE PROC SP_themTaikhoan(@usernam NVARCHAR(100),@Displayname NVARCHAR(100),@Password NVARCHAR(100),@type INT)
AS
BEGIN
	INSERT INTO Account(UserName,DisplayName,PassWord,Type)
	VALUES(@usernam,@Displayname,@Password,@type)
END
GO
--cap nhat tai khoan
CREATE PROC SP_capnhatTaikhoan(@usernam NVARCHAR(100),@Displayname NVARCHAR(100),@Password NVARCHAR(100),@type INT)
AS
BEGIN
	UPDATE Account
	SET DisplayName = @Displayname,PassWord = @Password,Type =@type
	WHERE UserName = @usernam
END
GO

EXEC SP_capnhatTaikhoan N'a',N'lainguyen',N'22',1
GO

EXEC SP_themTaikhoan N'a','admin','1',0
GO

--Delete taikhoan
CREATE PROC SP_xoaTaikhoan(@username NVARCHAR(100))
AS
BEGIN
	DELETE FROM Account
	WHERE UserName = @username
END
GO

EXEC SP_xoaTaikhoan N'a'
GO

--lay danh sach loai thuc uong
CREATE PROC SP_LoaiDrink
AS SELECT *FROM dbo.TypeDrink
GO

EXEC SP_LoaiDrink
GO

--them loai thuc uong
CREATE PROC SP_themLoaidrink(@name NVARCHAR(100))
AS
BEGIN
	INSERT INTO TypeDrink(name)
	VALUES(@name)
END
GO

EXEC SP_themLoaidrink N'cookies'
GO
--cap nhat loai thuc uong
CREATE PROC SP_capnhatLoaidrink(@id INT,@name NVARCHAR(100))
AS
BEGIN
	UPDATE TypeDrink
	SET name = @name
	WHERE id = @id
END
GO

EXEC SP_capnhatLoaidrink 1,N'caphe'
GO

--delete loai thuc uong
CREATE PROC SP_xoaLoaidrink(@id INT)
AS
BEGIN
	DELETE FROM TypeDrink
	WHERE id = @id
END
GO

EXEC SP_xoaLoaidrink 1
GO

--lay danh sach thuc uong
CREATE PROC SP_Drink
AS SELECT *FROM dbo.drink
GO

EXEC SP_Drink
GO

--them thuc uong
CREAtE PROC SP_themDrink(@name NVARCHAR(100),@idloai INT,@price FLOAT)
AS
BEGIN
	INSERT INTO drink(name,idTypeDrink,price)
	VALUES(@name,@idloai,@price)
END
GO

EXEC SP_themDrink N'socola',1,12000
GO

