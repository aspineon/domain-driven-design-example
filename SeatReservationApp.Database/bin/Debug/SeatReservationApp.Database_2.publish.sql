﻿/*
Deployment script for SeatReservationApp.Database

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "SeatReservationApp.Database"
:setvar DefaultFilePrefix "SeatReservationApp.Database"
:setvar DefaultDataPath "C:\Users\Usuario\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDb"
:setvar DefaultLogPath "C:\Users\Usuario\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDb"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Dropping [dbo].[FK_dbo.Booking.Seats_Id]...';


GO
ALTER TABLE [dbo].[Booking] DROP CONSTRAINT [FK_dbo.Booking.Seats_Id];


GO
PRINT N'Dropping [dbo].[FK_dbo.Booking.User_Id]...';


GO
ALTER TABLE [dbo].[Booking] DROP CONSTRAINT [FK_dbo.Booking.User_Id];


GO
PRINT N'Starting rebuilding table [dbo].[Booking]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_Booking] (
    [Id]        INT      IDENTITY (1, 1) NOT NULL,
    [SeatId]    INT      NULL,
    [Arrival]   DATETIME NOT NULL,
    [Departure] DATETIME NOT NULL,
    [UserId]    INT      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[Booking])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Booking] ON;
        INSERT INTO [dbo].[tmp_ms_xx_Booking] ([Id], [SeatId], [Arrival], [Departure], [UserId])
        SELECT   [Id],
                 [SeatId],
                 [Arrival],
                 [Departure],
                 [UserId]
        FROM     [dbo].[Booking]
        ORDER BY [Id] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_Booking] OFF;
    END

DROP TABLE [dbo].[Booking];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_Booking]', N'Booking';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Starting rebuilding table [dbo].[BookingSeats]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_BookingSeats] (
    [Id]     INT IDENTITY (1, 1) NOT NULL,
    [COLUMN] INT NOT NULL,
    [ROW]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[BookingSeats])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_BookingSeats] ON;
        INSERT INTO [dbo].[tmp_ms_xx_BookingSeats] ([Id], [COLUMN], [ROW])
        SELECT   [Id],
                 [COLUMN],
                 [ROW]
        FROM     [dbo].[BookingSeats]
        ORDER BY [Id] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_BookingSeats] OFF;
    END

DROP TABLE [dbo].[BookingSeats];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_BookingSeats]', N'BookingSeats';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Starting rebuilding table [dbo].[User]...';


GO
BEGIN TRANSACTION;

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;

SET XACT_ABORT ON;

CREATE TABLE [dbo].[tmp_ms_xx_User] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]  NVARCHAR (MAX) NOT NULL,
    [LastName]   NVARCHAR (MAX) NOT NULL,
    [PostalCode] NVARCHAR (50)  NOT NULL,
    [Address]    NVARCHAR (MAX) NOT NULL,
    [Country]    NVARCHAR (MAX) NOT NULL,
    [City]       NVARCHAR (MAX) NOT NULL,
    [Telephone]  NVARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

IF EXISTS (SELECT TOP 1 1 
           FROM   [dbo].[User])
    BEGIN
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_User] ON;
        INSERT INTO [dbo].[tmp_ms_xx_User] ([Id], [FirstName], [LastName], [PostalCode], [Address], [Country], [City], [Telephone])
        SELECT   [Id],
                 [FirstName],
                 [LastName],
                 [PostalCode],
                 [Address],
                 [Country],
                 [City],
                 [Telephone]
        FROM     [dbo].[User]
        ORDER BY [Id] ASC;
        SET IDENTITY_INSERT [dbo].[tmp_ms_xx_User] OFF;
    END

DROP TABLE [dbo].[User];

EXECUTE sp_rename N'[dbo].[tmp_ms_xx_User]', N'User';

COMMIT TRANSACTION;

SET TRANSACTION ISOLATION LEVEL READ COMMITTED;


GO
PRINT N'Creating [dbo].[FK_dbo.Booking.Seats_Id]...';


GO
ALTER TABLE [dbo].[Booking] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.Booking.Seats_Id] FOREIGN KEY ([SeatId]) REFERENCES [dbo].[BookingSeats] ([Id]) ON DELETE CASCADE;


GO
PRINT N'Creating [dbo].[FK_dbo.Booking.User_Id]...';


GO
ALTER TABLE [dbo].[Booking] WITH NOCHECK
    ADD CONSTRAINT [FK_dbo.Booking.User_Id] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id]);


GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[Booking] WITH CHECK CHECK CONSTRAINT [FK_dbo.Booking.Seats_Id];

ALTER TABLE [dbo].[Booking] WITH CHECK CHECK CONSTRAINT [FK_dbo.Booking.User_Id];


GO
PRINT N'Update complete.';


GO
