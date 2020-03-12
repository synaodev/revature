USE AdventureWorks2017;
GO



-- CREATE DATABASE PizzaBoxDb;
-- GO

-- CREATE SCHEMA Pizza;
-- GO

-- CREATE TABLE Pizza.Pizza (
-- 	PizzaID INT NOT NULL PRIMARY KEY IDENTITY(1, 2),
-- 	[Name] NVARCHAR(50) NOT NULL,
-- 	[Date] DATETIME2(7) CHECK (DATE >= GETDATE()),
-- 	[Active] BIT DEFAULT(1)
-- );
-- GO

-- CREATE VIEW vw_Pizza WITH SCHEMABINDING AS (
-- 	SELECT [Name] FROM Pizza.Pizza
-- );
-- GO

-- CREATE FUNCTION fn_Pizza(@D DATETIME2, @N NVARCHAR) RETURNS NVARCHAR AS
-- BEGIN
-- 	RETURN @N + ' ' + @D
-- END
-- GO

-- CREATE FUNCTION fn_Pizza2(@ID INT) RETURNS NVARCHAR AS
-- BEGIN
-- 	RETURN SELECT * FROM Pizza.Pizza WHERE PizzaId = @ID
-- END
-- GO

-- CREATE PROCEDURE sp_Procedure(@Name NVARCHAR) AS
-- BEGIN
-- 	BEGIN TRANSACTION
-- 		DECLARE @CheckName NVARCHAR;
-- 		SELECT @CheckName = NAME
-- 		FROM Pizza.Pizza
-- 		WHERE NAME = @CheckName
-- 		IF (@CheckName IS NULL)
-- 		BEGIN
-- 			INSERT INTO Pizza.Pizza(Name)
-- 			VALUES (@Name)
-- 			COMMIT TRANSACTION
-- 		END
-- 		ELSE
-- 		BEGIN
-- 			ROLLBACK TRANSACTION
-- 		END
-- 	END
-- END