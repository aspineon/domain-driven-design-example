CREATE TABLE [dbo].[Booking]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[SeatId] INT NULL,
	[Arrival] DATETIME NOT NULL,
	[Departure] DATETIME NOT NULL,
	[UserId] INT NOT NULL,
	CONSTRAINT [FK_dbo.Booking.Seats_Id] FOREIGN KEY ([SeatId]) REFERENCES [dbo].[BookingSeats] ([Id]) ON DELETE CASCADE,
	CONSTRAINT [FK_dbo.Booking.User_Id] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id])
)
