
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/12/2020 17:27:29
-- Generated from EDMX file: C:\Users\mihaela\source\repos\MyPhotos\MyPhotosApi\MyPhotosModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [C:\USERS\MIHAELA\DOCUMENTS\MYPHOTOS.MDF];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_FileCharacteristicValue_File]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FileCharacteristicValue] DROP CONSTRAINT [FK_FileCharacteristicValue_File];
GO
IF OBJECT_ID(N'[dbo].[FK_FileCharacteristicValue_CharacteristicValue]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[FileCharacteristicValue] DROP CONSTRAINT [FK_FileCharacteristicValue_CharacteristicValue];
GO
IF OBJECT_ID(N'[dbo].[FK_CharacteristicTypeCharacteristicValue]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[CharacteristicValues] DROP CONSTRAINT [FK_CharacteristicTypeCharacteristicValue];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Files]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Files];
GO
IF OBJECT_ID(N'[dbo].[CharacteristicTypes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CharacteristicTypes];
GO
IF OBJECT_ID(N'[dbo].[CharacteristicValues]', 'U') IS NOT NULL
    DROP TABLE [dbo].[CharacteristicValues];
GO
IF OBJECT_ID(N'[dbo].[FileCharacteristicValue]', 'U') IS NOT NULL
    DROP TABLE [dbo].[FileCharacteristicValue];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Files'
CREATE TABLE [dbo].[Files] (
    [Id] uniqueidentifier  NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [Type] bit  NOT NULL,
    [Date] datetime  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Erased] bit  NOT NULL
);
GO

-- Creating table 'CharacteristicTypes'
CREATE TABLE [dbo].[CharacteristicTypes] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CharacteristicValues'
CREATE TABLE [dbo].[CharacteristicValues] (
    [Id] uniqueidentifier  NOT NULL,
    [Value] nvarchar(max)  NOT NULL,
    [CharacteristicTypeId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'FileCharacteristicValue'
CREATE TABLE [dbo].[FileCharacteristicValue] (
    [Files_Id] uniqueidentifier  NOT NULL,
    [CharacteristicValues_Id] uniqueidentifier  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Files'
ALTER TABLE [dbo].[Files]
ADD CONSTRAINT [PK_Files]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CharacteristicTypes'
ALTER TABLE [dbo].[CharacteristicTypes]
ADD CONSTRAINT [PK_CharacteristicTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CharacteristicValues'
ALTER TABLE [dbo].[CharacteristicValues]
ADD CONSTRAINT [PK_CharacteristicValues]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Files_Id], [CharacteristicValues_Id] in table 'FileCharacteristicValue'
ALTER TABLE [dbo].[FileCharacteristicValue]
ADD CONSTRAINT [PK_FileCharacteristicValue]
    PRIMARY KEY CLUSTERED ([Files_Id], [CharacteristicValues_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Files_Id] in table 'FileCharacteristicValue'
ALTER TABLE [dbo].[FileCharacteristicValue]
ADD CONSTRAINT [FK_FileCharacteristicValue_File]
    FOREIGN KEY ([Files_Id])
    REFERENCES [dbo].[Files]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [CharacteristicValues_Id] in table 'FileCharacteristicValue'
ALTER TABLE [dbo].[FileCharacteristicValue]
ADD CONSTRAINT [FK_FileCharacteristicValue_CharacteristicValue]
    FOREIGN KEY ([CharacteristicValues_Id])
    REFERENCES [dbo].[CharacteristicValues]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FileCharacteristicValue_CharacteristicValue'
CREATE INDEX [IX_FK_FileCharacteristicValue_CharacteristicValue]
ON [dbo].[FileCharacteristicValue]
    ([CharacteristicValues_Id]);
GO

-- Creating foreign key on [CharacteristicTypeId] in table 'CharacteristicValues'
ALTER TABLE [dbo].[CharacteristicValues]
ADD CONSTRAINT [FK_CharacteristicTypeCharacteristicValue]
    FOREIGN KEY ([CharacteristicTypeId])
    REFERENCES [dbo].[CharacteristicTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CharacteristicTypeCharacteristicValue'
CREATE INDEX [IX_FK_CharacteristicTypeCharacteristicValue]
ON [dbo].[CharacteristicValues]
    ([CharacteristicTypeId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------