USE [WpDb]
GO

/****** Object: Table [dbo].[milestone] Script Date: 21.09.2016 16:49:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[milestone];


GO
CREATE TABLE [dbo].[milestone] (
    [Id]       INT           NOT NULL,
    [Label]    NVARCHAR (50) NOT NULL,
    [Contact]  NVARCHAR (50) NOT NULL,
    [Location] NVARCHAR (50) NULL,
    [Cost]     NVARCHAR (50) NOT NULL,
    [Date]     DATETIME      NOT NULL
);


