/*
Deployment script for WpDb
*/
USE [WpDb]
GO

/****** Object: Table [dbo].[usr] Script Date: 21.09.2016 16:49:24 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[alternative];
DROP TABLE [dbo].[probability];
DROP TABLE [dbo].[milestone];
DROP TABLE [dbo].[guest];
DROP TABLE [dbo].[usr];
DROP TABLE [dbo].[prediction];



CREATE TABLE [dbo].[prediction] (
    [Label] NCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([Label] ASC)
);

CREATE TABLE [dbo].[guest] (
    [Id]          INT           NOT NULL,
    [Name]        NVARCHAR (50) NULL,
    [Telefon]     NVARCHAR (50) NOT NULL,
    [Email]       NVARCHAR (50) NULL,
    [CompaniedBy] INT           NULL,
    [Chance]      NCHAR (10)    NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_CompaniedBy] FOREIGN KEY ([CompaniedBy]) REFERENCES [dbo].[guest] ([Id]),
    CONSTRAINT [FK_Probabilty] FOREIGN KEY ([Chance]) REFERENCES [dbo].[prediction] ([Label])
);

CREATE TABLE [dbo].[alternative] (
    [Id]       INT           NOT NULL,
    [Label]    NVARCHAR (50) NOT NULL,
    [Contact]  NVARCHAR (50) NOT NULL,
    [Location] NVARCHAR (50) NULL,
    [Cost]     INT           NOT NULL,
    [Date]     DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[milestone] (
    [Id]          INT NOT NULL,
    [Choice] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Alternative] FOREIGN KEY ([Choice]) REFERENCES [dbo].[alternative] ([Id])
);

CREATE TABLE [dbo].[usr] (
    [Id]       INT           NOT NULL,
    [Username] NVARCHAR (50) NULL,
    [Email]    NVARCHAR (50) NULL,
    [Task]     INT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Task] FOREIGN KEY ([Task]) REFERENCES [dbo].[milestone] ([Id])
);


