
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/09/2014 17:48:14
-- Generated from EDMX file: F:\翔工作室\艺术学院\ArtSchool\School\Models\School.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [school2014];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Activity]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Activity];
GO
IF OBJECT_ID(N'[dbo].[Admin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Admin];
GO
IF OBJECT_ID(N'[dbo].[dqwork]', 'U') IS NOT NULL
    DROP TABLE [dbo].[dqwork];
GO
IF OBJECT_ID(N'[dbo].[ImgBbox]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ImgBbox];
GO
IF OBJECT_ID(N'[dbo].[jingpin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[jingpin];
GO
IF OBJECT_ID(N'[dbo].[jwmanger]', 'U') IS NOT NULL
    DROP TABLE [dbo].[jwmanger];
GO
IF OBJECT_ID(N'[dbo].[News]', 'U') IS NOT NULL
    DROP TABLE [dbo].[News];
GO
IF OBJECT_ID(N'[dbo].[Notices]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Notices];
GO
IF OBJECT_ID(N'[dbo].[science]', 'U') IS NOT NULL
    DROP TABLE [dbo].[science];
GO
IF OBJECT_ID(N'[dbo].[Subject]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Subject];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[TeaTeam]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TeaTeam];
GO
IF OBJECT_ID(N'[dbo].[Tszh]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Tszh];
GO
IF OBJECT_ID(N'[dbo].[txwork]', 'U') IS NOT NULL
    DROP TABLE [dbo].[txwork];
GO
IF OBJECT_ID(N'[dbo].[wangluo]', 'U') IS NOT NULL
    DROP TABLE [dbo].[wangluo];
GO
IF OBJECT_ID(N'[dbo].[ywshow]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ywshow];
GO
IF OBJECT_ID(N'[dbo].[zhuanye]', 'U') IS NOT NULL
    DROP TABLE [dbo].[zhuanye];
GO
IF OBJECT_ID(N'[dbo].[ztmanger]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ztmanger];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'Activity'
CREATE TABLE [dbo].[Activity] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(50)  NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL
);
GO

-- Creating table 'Notices'
CREATE TABLE [dbo].[Notices] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(50)  NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [Date] datetime  NOT NULL,
    [Writer] nvarchar(15)  NOT NULL,
    [file] nvarchar(50)  NULL
);
GO

-- Creating table 'Tszh'
CREATE TABLE [dbo].[Tszh] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(50)  NOT NULL,
    [Content] nvarchar(max)  NOT NULL,
    [Time] datetime  NOT NULL,
    [file] nvarchar(250)  NULL
);
GO

-- Creating table 'Admin'
CREATE TABLE [dbo].[Admin] (
    [Name] nvarchar(50)  NOT NULL,
    [ID] int IDENTITY(1,1) NOT NULL,
    [PassWord] nvarchar(50)  NOT NULL,
    [Role] nvarchar(15)  NOT NULL
);
GO

-- Creating table 'Subject'
CREATE TABLE [dbo].[Subject] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(150)  NOT NULL,
    [content] nvarchar(max)  NOT NULL,
    [time] datetime  NOT NULL,
    [kind] nvarchar(50)  NOT NULL,
    [file] nvarchar(250)  NULL
);
GO

-- Creating table 'dqwork'
CREATE TABLE [dbo].[dqwork] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(50)  NOT NULL,
    [time] datetime  NOT NULL,
    [kind] nvarchar(50)  NOT NULL,
    [writer] nvarchar(50)  NOT NULL,
    [content] nvarchar(max)  NOT NULL,
    [file] nvarchar(250)  NULL
);
GO

-- Creating table 'jwmanger'
CREATE TABLE [dbo].[jwmanger] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(50)  NOT NULL,
    [time] datetime  NOT NULL,
    [kind] nvarchar(50)  NOT NULL,
    [writer] nvarchar(50)  NOT NULL,
    [content] nvarchar(max)  NOT NULL,
    [file] nvarchar(250)  NULL
);
GO

-- Creating table 'science'
CREATE TABLE [dbo].[science] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(50)  NOT NULL,
    [time] datetime  NOT NULL,
    [kind] nvarchar(50)  NOT NULL,
    [writer] nvarchar(50)  NOT NULL,
    [content] nvarchar(max)  NOT NULL,
    [file] nvarchar(250)  NULL
);
GO

-- Creating table 'ztmanger'
CREATE TABLE [dbo].[ztmanger] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(50)  NOT NULL,
    [time] datetime  NOT NULL,
    [writer] nvarchar(50)  NOT NULL,
    [content] nvarchar(max)  NOT NULL,
    [file] nvarchar(250)  NULL
);
GO

-- Creating table 'jingpin'
CREATE TABLE [dbo].[jingpin] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(50)  NOT NULL,
    [video] nvarchar(250)  NOT NULL,
    [img] nvarchar(250)  NOT NULL,
    [time] datetime  NOT NULL,
    [writer] nvarchar(50)  NOT NULL,
    [content] nvarchar(500)  NOT NULL,
    [pingjia] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'wangluo'
CREATE TABLE [dbo].[wangluo] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(50)  NOT NULL,
    [time] datetime  NOT NULL,
    [write] nvarchar(50)  NOT NULL,
    [img] nvarchar(150)  NOT NULL,
    [pingjia] nvarchar(50)  NOT NULL,
    [video] nvarchar(150)  NOT NULL,
    [content] nvarchar(250)  NOT NULL
);
GO

-- Creating table 'zhuanye'
CREATE TABLE [dbo].[zhuanye] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(50)  NOT NULL,
    [time] datetime  NOT NULL,
    [kind] nvarchar(50)  NOT NULL,
    [writer] nvarchar(50)  NOT NULL,
    [content] nvarchar(max)  NOT NULL,
    [file] nvarchar(250)  NULL
);
GO

-- Creating table 'TeaTeam'
CREATE TABLE [dbo].[TeaTeam] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [photo] nvarchar(150)  NOT NULL,
    [name] nvarchar(50)  NOT NULL,
    [job] nvarchar(50)  NOT NULL,
    [introduce] nvarchar(max)  NOT NULL,
    [kind] nvarchar(50)  NULL
);
GO

-- Creating table 'ImgBbox'
CREATE TABLE [dbo].[ImgBbox] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(50)  NULL,
    [Picture] nvarchar(50)  NULL,
    [Time] datetime  NULL
);
GO

-- Creating table 'News'
CREATE TABLE [dbo].[News] (
    [ID] bigint IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(100)  NULL,
    [Kind] nvarchar(50)  NULL,
    [Date] datetime  NULL,
    [Writer] nvarchar(50)  NULL,
    [Checked] nvarchar(50)  NULL,
    [Content] varchar(max)  NULL,
    [hit] bigint  NOT NULL,
    [file] nvarchar(350)  NULL
);
GO

-- Creating table 'ywshow'
CREATE TABLE [dbo].[ywshow] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [title] varchar(max)  NOT NULL,
    [time] datetime  NOT NULL,
    [kind] nvarchar(50)  NOT NULL,
    [writer] varchar(max)  NOT NULL,
    [content] varchar(max)  NOT NULL,
    [file] varchar(max)  NULL
);
GO

-- Creating table 'txwork'
CREATE TABLE [dbo].[txwork] (
    [ID] int IDENTITY(1,1) NOT NULL,
    [title] nvarchar(250)  NOT NULL,
    [time] datetime  NOT NULL,
    [kind] nvarchar(50)  NOT NULL,
    [writer] varchar(max)  NOT NULL,
    [content] varchar(max)  NOT NULL,
    [file] varchar(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [ID] in table 'Activity'
ALTER TABLE [dbo].[Activity]
ADD CONSTRAINT [PK_Activity]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Notices'
ALTER TABLE [dbo].[Notices]
ADD CONSTRAINT [PK_Notices]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Tszh'
ALTER TABLE [dbo].[Tszh]
ADD CONSTRAINT [PK_Tszh]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Admin'
ALTER TABLE [dbo].[Admin]
ADD CONSTRAINT [PK_Admin]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'Subject'
ALTER TABLE [dbo].[Subject]
ADD CONSTRAINT [PK_Subject]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'dqwork'
ALTER TABLE [dbo].[dqwork]
ADD CONSTRAINT [PK_dqwork]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'jwmanger'
ALTER TABLE [dbo].[jwmanger]
ADD CONSTRAINT [PK_jwmanger]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'science'
ALTER TABLE [dbo].[science]
ADD CONSTRAINT [PK_science]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ztmanger'
ALTER TABLE [dbo].[ztmanger]
ADD CONSTRAINT [PK_ztmanger]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'jingpin'
ALTER TABLE [dbo].[jingpin]
ADD CONSTRAINT [PK_jingpin]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'wangluo'
ALTER TABLE [dbo].[wangluo]
ADD CONSTRAINT [PK_wangluo]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'zhuanye'
ALTER TABLE [dbo].[zhuanye]
ADD CONSTRAINT [PK_zhuanye]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'TeaTeam'
ALTER TABLE [dbo].[TeaTeam]
ADD CONSTRAINT [PK_TeaTeam]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ImgBbox'
ALTER TABLE [dbo].[ImgBbox]
ADD CONSTRAINT [PK_ImgBbox]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'News'
ALTER TABLE [dbo].[News]
ADD CONSTRAINT [PK_News]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'ywshow'
ALTER TABLE [dbo].[ywshow]
ADD CONSTRAINT [PK_ywshow]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- Creating primary key on [ID] in table 'txwork'
ALTER TABLE [dbo].[txwork]
ADD CONSTRAINT [PK_txwork]
    PRIMARY KEY CLUSTERED ([ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------