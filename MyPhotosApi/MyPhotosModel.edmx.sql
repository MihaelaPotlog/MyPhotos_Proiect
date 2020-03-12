
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/12/2020 21:28:20
-- Generated from EDMX file: C:\Users\mihaela\source\repos\MyPhotos\MyPhotosApi\MyPhotosModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MyPhotos];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Files'
CREATE TABLE [dbo].[Files] (
    [Id] uniqueidentifier  NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Type] bit  NOT NULL,
    [Erased] bit  NOT NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'PropertyTypes'
CREATE TABLE [dbo].[PropertyTypes] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'PropertyValues'
CREATE TABLE [dbo].[PropertyValues] (
    [Id] uniqueidentifier  NOT NULL,
    [Value] nvarchar(max)  NOT NULL,
    [PropertyTypeId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'FilePropertyValue'
CREATE TABLE [dbo].[FilePropertyValue] (
    [Files_Id] uniqueidentifier  NOT NULL,
    [PropertyValues_Id] uniqueidentifier  NOT NULL
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

-- Creating primary key on [Id] in table 'PropertyTypes'
ALTER TABLE [dbo].[PropertyTypes]
ADD CONSTRAINT [PK_PropertyTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PropertyValues'
ALTER TABLE [dbo].[PropertyValues]
ADD CONSTRAINT [PK_PropertyValues]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Files_Id], [PropertyValues_Id] in table 'FilePropertyValue'
ALTER TABLE [dbo].[FilePropertyValue]
ADD CONSTRAINT [PK_FilePropertyValue]
    PRIMARY KEY CLUSTERED ([Files_Id], [PropertyValues_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PropertyTypeId] in table 'PropertyValues'
ALTER TABLE [dbo].[PropertyValues]
ADD CONSTRAINT [FK_PropertyTypePropertyValue]
    FOREIGN KEY ([PropertyTypeId])
    REFERENCES [dbo].[PropertyTypes]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PropertyTypePropertyValue'
CREATE INDEX [IX_FK_PropertyTypePropertyValue]
ON [dbo].[PropertyValues]
    ([PropertyTypeId]);
GO

-- Creating foreign key on [Files_Id] in table 'FilePropertyValue'
ALTER TABLE [dbo].[FilePropertyValue]
ADD CONSTRAINT [FK_FilePropertyValue_File]
    FOREIGN KEY ([Files_Id])
    REFERENCES [dbo].[Files]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PropertyValues_Id] in table 'FilePropertyValue'
ALTER TABLE [dbo].[FilePropertyValue]
ADD CONSTRAINT [FK_FilePropertyValue_PropertyValue]
    FOREIGN KEY ([PropertyValues_Id])
    REFERENCES [dbo].[PropertyValues]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilePropertyValue_PropertyValue'
CREATE INDEX [IX_FK_FilePropertyValue_PropertyValue]
ON [dbo].[FilePropertyValue]
    ([PropertyValues_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------