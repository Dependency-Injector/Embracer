
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/27/2015 06:27:55
-- Generated from EDMX file: D:\Projekty GIT\Embracer\Embracer\EmbracerEntities.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Embracer];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TimePeriodActivity]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ActivitySet] DROP CONSTRAINT [FK_TimePeriodActivity];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ActivitySet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ActivitySet];
GO
IF OBJECT_ID(N'[dbo].[TimePeriodSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TimePeriodSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ActivitySet'
CREATE TABLE [dbo].[ActivitySet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TimePeriodSet'
CREATE TABLE [dbo].[TimePeriodSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Start] datetime  NOT NULL,
    [Stop] datetime  NOT NULL,
    [Interval] smallint  NOT NULL,
    [Activity_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ActivitySet'
ALTER TABLE [dbo].[ActivitySet]
ADD CONSTRAINT [PK_ActivitySet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TimePeriodSet'
ALTER TABLE [dbo].[TimePeriodSet]
ADD CONSTRAINT [PK_TimePeriodSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Activity_Id] in table 'TimePeriodSet'
ALTER TABLE [dbo].[TimePeriodSet]
ADD CONSTRAINT [FK_ActivityTimePeriod]
    FOREIGN KEY ([Activity_Id])
    REFERENCES [dbo].[ActivitySet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ActivityTimePeriod'
CREATE INDEX [IX_FK_ActivityTimePeriod]
ON [dbo].[TimePeriodSet]
    ([Activity_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------