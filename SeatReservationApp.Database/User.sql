﻿CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[FirstName] NVARCHAR(MAX) NOT NULL,
	[LastName] NVARCHAR(MAX) NOT NULL,
	[PostalCode] NVARCHAR(50) NOT NULL,
	[Address] NVARCHAR(MAX) NOT NULL,
	[Country] NVARCHAR(MAX) NOT NULL,
	[City] NVARCHAR(MAX) NOT NULL,
	[Telephone] NVARCHAR(MAX) NOT NULL

)
