CREATE TABLE [dbo].[Aircraft]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[FligtNumber] VARCHAR(255) NOT NULL,
	[SeatsId] INT NULL
	CONSTRAINT [FK_dbo.Aircraft.Seats_Id] FOREIGN KEY ([SeatsId]) REFERENCES [dbo].[Seats] ([Id]) ON DELETE CASCADE

)
