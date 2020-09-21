
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/01/2016 18:49:49
-- Generated from EDMX file: C:\Users\Diego\Documents\Visual Studio 2013\Projects\ControleDeEstoque\ControleDeEstoque-branchSQLServer\ControleDeEstoque\Model\DBControleEstoque.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ControleEstoque];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_PreProdutoProduto]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Produtos] DROP CONSTRAINT [FK_PreProdutoProduto];
GO
IF OBJECT_ID(N'[dbo].[FK_ProdutoEstoque]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Estoque] DROP CONSTRAINT [FK_ProdutoEstoque];
GO
IF OBJECT_ID(N'[dbo].[FK_EstoqueExpedicao]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Expedicao] DROP CONSTRAINT [FK_EstoqueExpedicao];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[PreProdutos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PreProdutos];
GO
IF OBJECT_ID(N'[dbo].[Produtos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Produtos];
GO
IF OBJECT_ID(N'[dbo].[Estoque]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Estoque];
GO
IF OBJECT_ID(N'[dbo].[Expedicao]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Expedicao];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'PreProdutos'
CREATE TABLE [dbo].[PreProdutos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(60)  NOT NULL,
    [Sigla] nvarchar(10)  NOT NULL
);
GO

-- Creating table 'Produtos'
CREATE TABLE [dbo].[Produtos] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(60)  NOT NULL,
    [Litros] int  NOT NULL,
    [Revenda] bit  NULL,
    [PreProdutoId] int  NOT NULL
);
GO

-- Creating table 'Estoque'
CREATE TABLE [dbo].[Estoque] (
    [Lote] nvarchar(20)  NOT NULL,
    [ProdutoId] int  NOT NULL,
    [QuantidadeProduzida] int  NOT NULL,
    [QuantidadeDisponivel] int  NOT NULL
);
GO

-- Creating table 'Expedicao'
CREATE TABLE [dbo].[Expedicao] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [EstoqueLote] nvarchar(20)  NOT NULL,
    [EstoqueProdutoId] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [Quantidade] int  NOT NULL
);
GO

-- Creating table 'OrdemFabricacao'
CREATE TABLE [dbo].[OrdemFabricacao] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Lote] nvarchar(20)  NOT NULL,
    [PreProdutoId] int  NOT NULL,
    [Data] datetime  NOT NULL,
    [Envasado] bit  NOT NULL,
    [DataProducao] datetime  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'PreProdutos'
ALTER TABLE [dbo].[PreProdutos]
ADD CONSTRAINT [PK_PreProdutos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Produtos'
ALTER TABLE [dbo].[Produtos]
ADD CONSTRAINT [PK_Produtos]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Lote], [ProdutoId] in table 'Estoque'
ALTER TABLE [dbo].[Estoque]
ADD CONSTRAINT [PK_Estoque]
    PRIMARY KEY CLUSTERED ([Lote], [ProdutoId] ASC);
GO

-- Creating primary key on [Id] in table 'Expedicao'
ALTER TABLE [dbo].[Expedicao]
ADD CONSTRAINT [PK_Expedicao]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id], [Lote] in table 'OrdemFabricacao'
ALTER TABLE [dbo].[OrdemFabricacao]
ADD CONSTRAINT [PK_OrdemFabricacao]
    PRIMARY KEY CLUSTERED ([Id], [Lote] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PreProdutoId] in table 'Produtos'
ALTER TABLE [dbo].[Produtos]
ADD CONSTRAINT [FK_PreProdutoProduto]
    FOREIGN KEY ([PreProdutoId])
    REFERENCES [dbo].[PreProdutos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PreProdutoProduto'
CREATE INDEX [IX_FK_PreProdutoProduto]
ON [dbo].[Produtos]
    ([PreProdutoId]);
GO

-- Creating foreign key on [ProdutoId] in table 'Estoque'
ALTER TABLE [dbo].[Estoque]
ADD CONSTRAINT [FK_ProdutoEstoque]
    FOREIGN KEY ([ProdutoId])
    REFERENCES [dbo].[Produtos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProdutoEstoque'
CREATE INDEX [IX_FK_ProdutoEstoque]
ON [dbo].[Estoque]
    ([ProdutoId]);
GO

-- Creating foreign key on [EstoqueLote], [EstoqueProdutoId] in table 'Expedicao'
ALTER TABLE [dbo].[Expedicao]
ADD CONSTRAINT [FK_EstoqueExpedicao]
    FOREIGN KEY ([EstoqueLote], [EstoqueProdutoId])
    REFERENCES [dbo].[Estoque]
        ([Lote], [ProdutoId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EstoqueExpedicao'
CREATE INDEX [IX_FK_EstoqueExpedicao]
ON [dbo].[Expedicao]
    ([EstoqueLote], [EstoqueProdutoId]);
GO

-- Creating foreign key on [PreProdutoId] in table 'OrdemFabricacao'
ALTER TABLE [dbo].[OrdemFabricacao]
ADD CONSTRAINT [FK_PreProdutoOrdemFabricacao]
    FOREIGN KEY ([PreProdutoId])
    REFERENCES [dbo].[PreProdutos]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_PreProdutoOrdemFabricacao'
CREATE INDEX [IX_FK_PreProdutoOrdemFabricacao]
ON [dbo].[OrdemFabricacao]
    ([PreProdutoId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------