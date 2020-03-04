
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/04/2020 12:30:09
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
    [Type] bit  NOT NULL,
    [Date] datetime  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Erased] bit  NOT NULL
);
GO

-- Creating table 'Eveniments'
CREATE TABLE [dbo].[Eveniments] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Places'
CREATE TABLE [dbo].[Places] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'People'
CREATE TABLE [dbo].[People] (
    [Id] uniqueidentifier  NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Characteristics'
CREATE TABLE [dbo].[Characteristics] (
    [Id] uniqueidentifier  NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'CharacteristicValues'
CREATE TABLE [dbo].[CharacteristicValues] (
    [Id] uniqueidentifier  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [CharacteristicId] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'FileEveniment'
CREATE TABLE [dbo].[FileEveniment] (
    [Files_Id] uniqueidentifier  NOT NULL,
    [Eveniments_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'FilePerson'
CREATE TABLE [dbo].[FilePerson] (
    [Files_Id] uniqueidentifier  NOT NULL,
    [People_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'FilePlace'
CREATE TABLE [dbo].[FilePlace] (
    [Files_Id] uniqueidentifier  NOT NULL,
    [Places_Id] uniqueidentifier  NOT NULL
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

-- Creating primary key on [Id] in table 'Eveniments'
ALTER TABLE [dbo].[Eveniments]
ADD CONSTRAINT [PK_Eveniments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Places'
ALTER TABLE [dbo].[Places]
ADD CONSTRAINT [PK_Places]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'People'
ALTER TABLE [dbo].[People]
ADD CONSTRAINT [PK_People]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Characteristics'
ALTER TABLE [dbo].[Characteristics]
ADD CONSTRAINT [PK_Characteristics]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'CharacteristicValues'
ALTER TABLE [dbo].[CharacteristicValues]
ADD CONSTRAINT [PK_CharacteristicValues]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Files_Id], [Eveniments_Id] in table 'FileEveniment'
ALTER TABLE [dbo].[FileEveniment]
ADD CONSTRAINT [PK_FileEveniment]
    PRIMARY KEY CLUSTERED ([Files_Id], [Eveniments_Id] ASC);
GO

-- Creating primary key on [Files_Id], [People_Id] in table 'FilePerson'
ALTER TABLE [dbo].[FilePerson]
ADD CONSTRAINT [PK_FilePerson]
    PRIMARY KEY CLUSTERED ([Files_Id], [People_Id] ASC);
GO

-- Creating primary key on [Files_Id], [Places_Id] in table 'FilePlace'
ALTER TABLE [dbo].[FilePlace]
ADD CONSTRAINT [PK_FilePlace]
    PRIMARY KEY CLUSTERED ([Files_Id], [Places_Id] ASC);
GO

-- Creating primary key on [Files_Id], [CharacteristicValues_Id] in table 'FileCharacteristicValue'
ALTER TABLE [dbo].[FileCharacteristicValue]
ADD CONSTRAINT [PK_FileCharacteristicValue]
    PRIMARY KEY CLUSTERED ([Files_Id], [CharacteristicValues_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Files_Id] in table 'FileEveniment'
ALTER TABLE [dbo].[FileEveniment]
ADD CONSTRAINT [FK_FileEveniment_File]
    FOREIGN KEY ([Files_Id])
    REFERENCES [dbo].[Files]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Eveniments_Id] in table 'FileEveniment'
ALTER TABLE [dbo].[FileEveniment]
ADD CONSTRAINT [FK_FileEveniment_Eveniment]
    FOREIGN KEY ([Eveniments_Id])
    REFERENCES [dbo].[Eveniments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FileEveniment_Eveniment'
CREATE INDEX [IX_FK_FileEveniment_Eveniment]
ON [dbo].[FileEveniment]
    ([Eveniments_Id]);
GO

-- Creating foreign key on [Files_Id] in table 'FilePerson'
ALTER TABLE [dbo].[FilePerson]
ADD CONSTRAINT [FK_FilePerson_File]
    FOREIGN KEY ([Files_Id])
    REFERENCES [dbo].[Files]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [People_Id] in table 'FilePerson'
ALTER TABLE [dbo].[FilePerson]
ADD CONSTRAINT [FK_FilePerson_Person]
    FOREIGN KEY ([People_Id])
    REFERENCES [dbo].[People]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilePerson_Person'
CREATE INDEX [IX_FK_FilePerson_Person]
ON [dbo].[FilePerson]
    ([People_Id]);
GO

-- Creating foreign key on [Files_Id] in table 'FilePlace'
ALTER TABLE [dbo].[FilePlace]
ADD CONSTRAINT [FK_FilePlace_File]
    FOREIGN KEY ([Files_Id])
    REFERENCES [dbo].[Files]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Places_Id] in table 'FilePlace'
ALTER TABLE [dbo].[FilePlace]
ADD CONSTRAINT [FK_FilePlace_Place]
    FOREIGN KEY ([Places_Id])
    REFERENCES [dbo].[Places]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FilePlace_Place'
CREATE INDEX [IX_FK_FilePlace_Place]
ON [dbo].[FilePlace]
    ([Places_Id]);
GO

-- Creating foreign key on [CharacteristicId] in table 'CharacteristicValues'
ALTER TABLE [dbo].[CharacteristicValues]
ADD CONSTRAINT [FK_CharacteristicCharacteristicValue]
    FOREIGN KEY ([CharacteristicId])
    REFERENCES [dbo].[Characteristics]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CharacteristicCharacteristicValue'
CREATE INDEX [IX_FK_CharacteristicCharacteristicValue]
ON [dbo].[CharacteristicValues]
    ([CharacteristicId]);
GO

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

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------