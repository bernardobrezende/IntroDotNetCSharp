
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 06/27/2012 16:38:39
-- Generated from EDMX file: C:\Users\bernardobosak.CWINET\Desktop\CSharpEntityFramework.Web\CSharpEntityFramework.Web\Models\TweetBeer.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TweetBeer];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Beer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Beer];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Beer'
CREATE TABLE [dbo].[Beer] (
    [Id] bigint IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(255)  NOT NULL,
    [Country] nvarchar(max)  NOT NULL,
    [Weight] float  NOT NULL,
    [InitialWeight] float  NOT NULL,
    [IsOpened] bit  NOT NULL
);
GO

-- Creating table 'Beer_StoutBeer'
CREATE TABLE [dbo].[Beer_StoutBeer] (
    [Id] bigint  NOT NULL
);
GO

-- Creating table 'Beer_PremiumBeer'
CREATE TABLE [dbo].[Beer_PremiumBeer] (
    [Id] bigint  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Beer'
ALTER TABLE [dbo].[Beer]
ADD CONSTRAINT [PK_Beer]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Beer_StoutBeer'
ALTER TABLE [dbo].[Beer_StoutBeer]
ADD CONSTRAINT [PK_Beer_StoutBeer]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Beer_PremiumBeer'
ALTER TABLE [dbo].[Beer_PremiumBeer]
ADD CONSTRAINT [PK_Beer_PremiumBeer]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Id] in table 'Beer_StoutBeer'
ALTER TABLE [dbo].[Beer_StoutBeer]
ADD CONSTRAINT [FK_StoutBeer_inherits_Beer]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Beer]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Beer_PremiumBeer'
ALTER TABLE [dbo].[Beer_PremiumBeer]
ADD CONSTRAINT [FK_PremiumBeer_inherits_Beer]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Beer]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------