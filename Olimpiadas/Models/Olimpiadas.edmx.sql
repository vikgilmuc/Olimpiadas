
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/14/2014 07:47:03
-- Generated from EDMX file: D:\Labfiles\Mod03\Olimpiadas\Olimpiadas\Models\Olimpiadas.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Olimpiadas];
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

-- Creating table 'Pais'
CREATE TABLE [dbo].[Pais] (
    [ISO] nvarchar(max)  NOT NULL,
    [nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Deportistas'
CREATE TABLE [dbo].[Deportistas] (
    [dorsal] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL,
    [edad] int  NOT NULL,
    [calificacion] decimal(18,0)  NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [descripcion] nvarchar(250)  NOT NULL,
    [fechaNacimiento] datetime  NOT NULL,
    [ISO] nvarchar(max)  NOT NULL,
    [Pais_ISO] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Pruebas'
CREATE TABLE [dbo].[Pruebas] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [nombre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Calificaciones'
CREATE TABLE [dbo].[Calificaciones] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [dorsal] int  NOT NULL,
    [idePrueba] nvarchar(max)  NOT NULL,
    [fecha] nvarchar(max)  NOT NULL,
    [posicion] bigint  NOT NULL,
    [Deportista_dorsal] int  NOT NULL,
    [Prueba_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ISO] in table 'Pais'
ALTER TABLE [dbo].[Pais]
ADD CONSTRAINT [PK_Pais]
    PRIMARY KEY CLUSTERED ([ISO] ASC);
GO

-- Creating primary key on [dorsal] in table 'Deportistas'
ALTER TABLE [dbo].[Deportistas]
ADD CONSTRAINT [PK_Deportistas]
    PRIMARY KEY CLUSTERED ([dorsal] ASC);
GO

-- Creating primary key on [Id] in table 'Pruebas'
ALTER TABLE [dbo].[Pruebas]
ADD CONSTRAINT [PK_Pruebas]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Calificaciones'
ALTER TABLE [dbo].[Calificaciones]
ADD CONSTRAINT [PK_Calificaciones]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Pais_ISO] in table 'Deportistas'
ALTER TABLE [dbo].[Deportistas]
ADD CONSTRAINT [FK_PaisDeportista]
    FOREIGN KEY ([Pais_ISO])
    REFERENCES [dbo].[Pais]
        ([ISO])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PaisDeportista'
CREATE INDEX [IX_FK_PaisDeportista]
ON [dbo].[Deportistas]
    ([Pais_ISO]);
GO

-- Creating foreign key on [Deportista_dorsal] in table 'Calificaciones'
ALTER TABLE [dbo].[Calificaciones]
ADD CONSTRAINT [FK_DeportistaCalificaciones]
    FOREIGN KEY ([Deportista_dorsal])
    REFERENCES [dbo].[Deportistas]
        ([dorsal])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_DeportistaCalificaciones'
CREATE INDEX [IX_FK_DeportistaCalificaciones]
ON [dbo].[Calificaciones]
    ([Deportista_dorsal]);
GO

-- Creating foreign key on [Prueba_Id] in table 'Calificaciones'
ALTER TABLE [dbo].[Calificaciones]
ADD CONSTRAINT [FK_PruebaCalificaciones]
    FOREIGN KEY ([Prueba_Id])
    REFERENCES [dbo].[Pruebas]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PruebaCalificaciones'
CREATE INDEX [IX_FK_PruebaCalificaciones]
ON [dbo].[Calificaciones]
    ([Prueba_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------