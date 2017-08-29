CREATE DATABASE PersonalContact
GO

USE PersonalContact
GO

CREATE TABLE Contact
(
	ID INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	[FullName] NCHAR(50) NOT NULL,
	[Group] NCHAR(20) NULL,
	[Address] nchar(100) NULL,
	Phone nchar(20) NOT NULL
)
GO

SELECT * FROM Contact