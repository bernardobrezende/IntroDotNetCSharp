
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 06/27/2012 19:35:15
-- Generated from EDMX file: C:\Users\aluno\Desktop\git\IntroDotNetCSharp\src\Day-8\CSharpEntityFramework.Web\CSharpEntityFramework.Web\Models\TweetBeer.edmx
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

IF OBJECT_ID(N'[dbo].[FK_StoutBeer_inherits_Beer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Beer_StoutBeer] DROP CONSTRAINT [FK_StoutBeer_inherits_Beer];
GO
IF OBJECT_ID(N'[dbo].[FK_PremiumBeer_inherits_Beer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Beer_PremiumBeer] DROP CONSTRAINT [FK_PremiumBeer_inherits_Beer];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Beer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Beer];
GO
IF OBJECT_ID(N'[dbo].[Beer_StoutBeer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Beer_StoutBeer];
GO
IF OBJECT_ID(N'[dbo].[Beer_PremiumBeer]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Beer_PremiumBeer];
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
    [InitialWeight] float  NOT NULL
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