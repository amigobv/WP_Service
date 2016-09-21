USE [WpDb]
GO

/****** Object: Table [dbo].[usr] Script Date: 21.09.2016 16:49:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[usr];


GO
CREATE TABLE [dbo].[usr] (
    [Id]       INT           NOT NULL,
    [Username] NVARCHAR (50) NULL,
    [Email]    NVARCHAR (50) NULL
);


