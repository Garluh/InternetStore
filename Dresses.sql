/*
Navicat SQL Server Data Transfer

Source Server         : Psy
Source Server Version : 90000
Source Host           : 192.168.1.8:1433
Source Database       : DressStore
Source Schema         : dbo

Target Server Type    : SQL Server
Target Server Version : 90000
File Encoding         : 65001

Date: 2017-06-16 17:18:52
*/


-- ----------------------------
-- Table structure for [dbo].[Dresses]
-- ----------------------------
DROP TABLE [dbo].[Dresses]
GO
CREATE TABLE [dbo].[Dresses] (
[DressId] int NOT NULL IDENTITY(1,1) ,
[Name] nvarchar(MAX) NULL ,
[Description] nvarchar(MAX) NULL ,
[SpecOffer] nvarchar(MAX) NULL ,
[Image] nvarchar(MAX) NULL ,
[Price] decimal(18,2) NOT NULL ,
[Category] nvarchar(MAX) NULL 
)


GO
DBCC CHECKIDENT(N'[dbo].[Dresses]', RESEED, 11)
GO

-- ----------------------------
-- Records of Dresses
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Dresses] ON
GO
INSERT INTO [dbo].[Dresses] ([DressId], [Name], [Description], [SpecOffer], [Image], [Price], [Category]) VALUES (N'5', N'Синий отблеск', N'Ткань и нитки очень выразительны', N'Купи сейчас и бутылка вина в подарок', null, N'1200.00', N'Готовое');
GO
INSERT INTO [dbo].[Dresses] ([DressId], [Name], [Description], [SpecOffer], [Image], [Price], [Category]) VALUES (N'6', N'Взгляд глубины', N'Темно-синий талас и бла бла бла', null, null, N'800.00', N'Готовое');
GO
INSERT INTO [dbo].[Dresses] ([DressId], [Name], [Description], [SpecOffer], [Image], [Price], [Category]) VALUES (N'7', N'Каратель сердец', N'Алый бархат и еще че-то там', null, null, N'999.00', N'Партнерское');
GO
INSERT INTO [dbo].[Dresses] ([DressId], [Name], [Description], [SpecOffer], [Image], [Price], [Category]) VALUES (N'8', N'Висюльки', N'Рюшечки и веревочки', N'Купи и набор отвертко в подарок', null, N'1200.00', N'Для примера');
GO
INSERT INTO [dbo].[Dresses] ([DressId], [Name], [Description], [SpecOffer], [Image], [Price], [Category]) VALUES (N'9', N'Мутный взгляд', N'Точно что мутный', null, null, N'800.00', N'Для примера');
GO
INSERT INTO [dbo].[Dresses] ([DressId], [Name], [Description], [SpecOffer], [Image], [Price], [Category]) VALUES (N'10', N'Странное нечто', N'что это такое', N'Обязательно надо брать', null, N'999.00', N'Партнерское');
GO
INSERT INTO [dbo].[Dresses] ([DressId], [Name], [Description], [SpecOffer], [Image], [Price], [Category]) VALUES (N'11', N'Вырви глаз', N'Мои глаза вытекают от этого чуда', null, null, N'300.00', N'Партнерское');
GO
SET IDENTITY_INSERT [dbo].[Dresses] OFF
GO

-- ----------------------------
-- Indexes structure for table Dresses
-- ----------------------------

-- ----------------------------
-- Primary Key structure for table [dbo].[Dresses]
-- ----------------------------
ALTER TABLE [dbo].[Dresses] ADD PRIMARY KEY ([DressId])
GO
