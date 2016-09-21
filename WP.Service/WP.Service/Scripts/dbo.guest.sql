USE [WpDb]
GO

/****** Object: Table [dbo].[guest] Script Date: 21.09.2016 16:48:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[guest];


GO
CREATE TABLE [dbo].[guest] (
    [Id]          INT           NOT NULL,
    [Name]        NVARCHAR (50) NULL,
    [Telefon]     NVARCHAR (50) NOT NULL,
    [Email]       NVARCHAR (50) NULL,
    [CompaniedBy] INT           NULL,
    [Chance]      NCHAR (10)    NOT NULL
);


