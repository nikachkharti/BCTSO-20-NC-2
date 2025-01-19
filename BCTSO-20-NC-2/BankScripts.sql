--CREATE DATABASE MiniBankBCTSO20N
--GO

--USE MiniBankBCTSO20N
--GO

--CREATE TABLE Customers
--(
--	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
--	[Name] NVARCHAR(50) NOT NULL,
--	IdentityNumber CHAR(11) CHECK(LEN(IdentityNumber)=11) UNIQUE  NOT NULL,
--	PhoneNumber VARCHAR(25) UNIQUE NOT NULL,
--	Email VARCHAR(50) UNIQUE NOT NULL,
--	[Type] TINYINT NOT NULL CHECK([Type] = 0 OR [Type] = 1)
--)

--CREATE TABLE Accounts
--(
--	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
--	Iban CHAR(22) CHECK(LEN(Iban)=22) NOT NULL,
--	Currency CHAR(3) NOT NULL,
--	Balance MONEY NOT NULL,
--	[Name] NVARCHAR(MAX) NULL,
--	CustomerId INT FOREIGN KEY REFERENCES Customers(Id)
--)

--CREATE TABLE Operations
--(
--	Id INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
--	OperationType TINYINT CHECK(OperationType = 0 OR OperationType = 1 OR OperationType = 2) NOT NULL,
--	Currency CHAR(3) NOT NULL,
--	Amount MONEY NOT NULL,
--	HappendAt DATETIME NOT NULL,
--	AccountId INT FOREIGN KEY REFERENCES Accounts(Id)
--)


--CREATE PROCEDURE spGetAllCustomers
--AS
--BEGIN
--	SELECT*FROM Customers
--END


--CREATE PROCEDURE spGetSingleCustomer
--@customerId INT
--AS
--BEGIN
--	SELECT*FROM Customers
--	WHERE Id = @customerId
--END



--CREATE PROCEDURE spAddNewCustomer
--@name NVARCHAR(50),
--@identityNumber CHAR(11),
--@phoneNumber VARCHAR(25),
--@email VARCHAR(50),
--@customerType TINYINT
--AS
--BEGIN
--	INSERT INTO Customers([Name],IdentityNumber,PhoneNumber,Email,[Type])
--	VALUES(@name,@identityNumber,@phoneNumber,@email,@customerType)
--END



--CREATE PROCEDURE spUpdateCustomer
--@customerId INT,
--@name NVARCHAR(50),
--@identityNumber CHAR(11),
--@phoneNumber VARCHAR(25),
--@email VARCHAR(50),
--@customerType TINYINT
--AS
--BEGIN
--	UPDATE Customers
--	SET 
--		[Name] = @name,
--		IdentityNumber = @identityNumber,
--		PhoneNumber = @phoneNumber,
--		Email = @email,
--		[Type] = @customerType
--	WHERE Id = @customerId
--END


--CREATE PROCEDURE spDeleteCustomer
--@customerId INT
--AS
--BEGIN
--	DELETE FROM Customers
--	WHERE Id = @customerId
--END