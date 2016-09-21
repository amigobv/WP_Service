USE [WpDb]
GO

/****** Object: Table [dbo].[alternative] Script Date: 21.09.2016 16:48:07 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[alternative];


GO
CREATE TABLE [dbo].[alternative] (
    [Id]          INT NOT NULL,
    [MilestoneFk] INT NOT NULL
);


