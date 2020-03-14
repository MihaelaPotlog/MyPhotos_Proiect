
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/14/2020 13:35:47
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

-- Creating table 'PropertyValues'
CREATE TABLE [dbo].[PropertyValues] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Value] nvarchar(max)  NOT NULL,
    [PropertyTypeId] int  NOT NULL
);
GO

-- Creating table 'PropertyTypes'
CREATE TABLE [dbo].[PropertyTypes] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'MediaFiles'
CREATE TABLE [dbo].[MediaFiles] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Path] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Type] bit  NOT NULL,
    [Erased] bit  NOT NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'MediaFilePropertyValue'
CREATE TABLE [dbo].[MediaFilePropertyValue] (
    [MediaFiles_Id] int  NOT NULL,
    [PropertyValues_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PropertyValues'
ALTER TABLE [dbo].[PropertyValues]
ADD CONSTRAINT [PK_PropertyValues]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PropertyTypes'
ALTER TABLE [dbo].[PropertyTypes]
ADD CONSTRAINT [PK_PropertyTypes]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MediaFiles'
ALTER TABLE [dbo].[MediaFiles]
ADD CONSTRAINT [PK_MediaFiles]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [MediaFiles_Id], [PropertyValues_Id] in table 'MediaFilePropertyValue'
ALTER TABLE [dbo].[MediaFilePropertyValue]
ADD CONSTRAINT [PK_MediaFilePropertyValue]
    PRIMARY KEY CLUSTERED ([MediaFiles_Id], [PropertyValues_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [MediaFiles_Id] in table 'MediaFilePropertyValue'
ALTER TABLE [dbo].[MediaFilePropertyValue]
ADD CONSTRAINT [FK_MediaFilePropertyValue_MediaFile]
    FOREIGN KEY ([MediaFiles_Id])
    REFERENCES [dbo].[MediaFiles]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [PropertyValues_Id] in table 'MediaFilePropertyValue'
ALTER TABLE [dbo].[MediaFilePropertyValue]
ADD CONSTRAINT [FK_MediaFilePropertyValue_PropertyValue]
    FOREIGN KEY ([PropertyValues_Id])
    REFERENCES [dbo].[PropertyValues]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MediaFilePropertyValue_PropertyValue'
CREATE INDEX [IX_FK_MediaFilePropertyValue_PropertyValue]
ON [dbo].[MediaFilePropertyValue]
    ([PropertyValues_Id]);
GO

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

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------