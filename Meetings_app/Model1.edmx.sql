
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/18/2023 12:08:44
-- Generated from EDMX file: C:\Users\79632\source\repos\Meetings_app\Meetings_app\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MeetingsDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MeetingPersonList]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MeetingSet] DROP CONSTRAINT [FK_MeetingPersonList];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[MeetingSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MeetingSet];
GO
IF OBJECT_ID(N'[dbo].[PersonListSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PersonListSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'MeetingSet'
CREATE TABLE [dbo].[MeetingSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Date] datetime  NOT NULL,
    [Time] time  NOT NULL,
    [Place] nvarchar(max)  NOT NULL,
    [Topic] nvarchar(max)  NOT NULL,
    [PersonListId] int  NOT NULL
);
GO

-- Creating table 'PersonListSet'
CREATE TABLE [dbo].[PersonListSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'MeetingSet'
ALTER TABLE [dbo].[MeetingSet]
ADD CONSTRAINT [PK_MeetingSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PersonListSet'
ALTER TABLE [dbo].[PersonListSet]
ADD CONSTRAINT [PK_PersonListSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PersonListId] in table 'MeetingSet'
ALTER TABLE [dbo].[MeetingSet]
ADD CONSTRAINT [FK_MeetingPersonList]
    FOREIGN KEY ([PersonListId])
    REFERENCES [dbo].[PersonListSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MeetingPersonList'
CREATE INDEX [IX_FK_MeetingPersonList]
ON [dbo].[MeetingSet]
    ([PersonListId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------