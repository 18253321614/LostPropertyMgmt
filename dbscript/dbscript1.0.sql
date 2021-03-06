USE [master]
GO
/****** Object:  Database [basicLandMamt]    Script Date: 11/13/2018 18:48:31 ******/
CREATE DATABASE [basicLandMamt] ON  PRIMARY 
( NAME = N'basicLandMamt', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\basicLandMamt.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'basicLandMamt_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\basicLandMamt_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [basicLandMamt] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [basicLandMamt].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [basicLandMamt] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [basicLandMamt] SET ANSI_NULLS OFF
GO
ALTER DATABASE [basicLandMamt] SET ANSI_PADDING OFF
GO
ALTER DATABASE [basicLandMamt] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [basicLandMamt] SET ARITHABORT OFF
GO
ALTER DATABASE [basicLandMamt] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [basicLandMamt] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [basicLandMamt] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [basicLandMamt] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [basicLandMamt] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [basicLandMamt] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [basicLandMamt] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [basicLandMamt] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [basicLandMamt] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [basicLandMamt] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [basicLandMamt] SET  DISABLE_BROKER
GO
ALTER DATABASE [basicLandMamt] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [basicLandMamt] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [basicLandMamt] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [basicLandMamt] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [basicLandMamt] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [basicLandMamt] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [basicLandMamt] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [basicLandMamt] SET  READ_WRITE
GO
ALTER DATABASE [basicLandMamt] SET RECOVERY FULL
GO
ALTER DATABASE [basicLandMamt] SET  MULTI_USER
GO
ALTER DATABASE [basicLandMamt] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [basicLandMamt] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'basicLandMamt', N'ON'
GO
USE [basicLandMamt]
GO
/****** Object:  Table [dbo].[tb_village]    Script Date: 11/13/2018 18:48:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_village](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[villageName] [nvarchar](10) NULL,
	[pointX] [decimal](18, 10) NULL,
	[pointY] [decimal](18, 10) NULL,
 CONSTRAINT [PK_tb_village] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_village] ON
INSERT [dbo].[tb_village] ([ID], [villageName], [pointX], [pointY]) VALUES (5, N'新桥村', CAST(116.3454693520 AS Decimal(18, 10)), CAST(37.1730795834 AS Decimal(18, 10)))
INSERT [dbo].[tb_village] ([ID], [villageName], [pointX], [pointY]) VALUES (7, N'花园村', CAST(116.3475078308 AS Decimal(18, 10)), CAST(37.1665242645 AS Decimal(18, 10)))
INSERT [dbo].[tb_village] ([ID], [villageName], [pointX], [pointY]) VALUES (8, N'东屯社区', CAST(116.3148063385 AS Decimal(18, 10)), CAST(37.1606877777 AS Decimal(18, 10)))
INSERT [dbo].[tb_village] ([ID], [villageName], [pointX], [pointY]) VALUES (9, N'赵庄村', CAST(116.3470357620 AS Decimal(18, 10)), CAST(37.1792701218 AS Decimal(18, 10)))
INSERT [dbo].[tb_village] ([ID], [villageName], [pointX], [pointY]) VALUES (10, N'郭家堂社区', CAST(116.3314574921 AS Decimal(18, 10)), CAST(37.1804288361 AS Decimal(18, 10)))
INSERT [dbo].[tb_village] ([ID], [villageName], [pointX], [pointY]) VALUES (12, N'王打卦社区', CAST(116.3301378453 AS Decimal(18, 10)), CAST(37.1665779087 AS Decimal(18, 10)))
INSERT [dbo].[tb_village] ([ID], [villageName], [pointX], [pointY]) VALUES (14, N'下河疃', NULL, NULL)
INSERT [dbo].[tb_village] ([ID], [villageName], [pointX], [pointY]) VALUES (15, N'毕游村', NULL, NULL)
INSERT [dbo].[tb_village] ([ID], [villageName], [pointX], [pointY]) VALUES (16, N'后宋村', CAST(116.3434737885 AS Decimal(18, 10)), CAST(37.1954706642 AS Decimal(18, 10)))
INSERT [dbo].[tb_village] ([ID], [villageName], [pointX], [pointY]) VALUES (21, N'测试', CAST(118.0000000000 AS Decimal(18, 10)), CAST(37.0000000000 AS Decimal(18, 10)))
SET IDENTITY_INSERT [dbo].[tb_village] OFF
/****** Object:  Table [dbo].[tb_user]    Script Date: 11/13/2018 18:48:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_user](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[userName] [nvarchar](10) NULL,
	[psaaword] [varchar](20) NULL,
 CONSTRAINT [PK_tb_user] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tb_landTJ]    Script Date: 11/13/2018 18:48:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_landTJ](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[year] [int] NULL,
	[landArea] [float] NULL,
 CONSTRAINT [PK_tb_landTJ] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_landTJ] ON
INSERT [dbo].[tb_landTJ] ([ID], [year], [landArea]) VALUES (1, 2009, 89999)
INSERT [dbo].[tb_landTJ] ([ID], [year], [landArea]) VALUES (2, 2010, 65456)
INSERT [dbo].[tb_landTJ] ([ID], [year], [landArea]) VALUES (3, 2011, 78956)
INSERT [dbo].[tb_landTJ] ([ID], [year], [landArea]) VALUES (4, 2012, 85462)
INSERT [dbo].[tb_landTJ] ([ID], [year], [landArea]) VALUES (5, 2013, 87562)
INSERT [dbo].[tb_landTJ] ([ID], [year], [landArea]) VALUES (6, 2014, 79653)
INSERT [dbo].[tb_landTJ] ([ID], [year], [landArea]) VALUES (7, 2015, 84167)
INSERT [dbo].[tb_landTJ] ([ID], [year], [landArea]) VALUES (8, 2016, 68954)
INSERT [dbo].[tb_landTJ] ([ID], [year], [landArea]) VALUES (9, 2017, 77892)
SET IDENTITY_INSERT [dbo].[tb_landTJ] OFF
/****** Object:  Table [dbo].[tb_admin]    Script Date: 11/13/2018 18:48:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tb_admin](
	[adminName] [nvarchar](10) NULL,
	[adminPwd] [varchar](20) NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[mark] [nvarchar](50) NULL,
 CONSTRAINT [PK_tb_admin] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tb_admin] ON
INSERT [dbo].[tb_admin] ([adminName], [adminPwd], [ID], [mark]) VALUES (N'admin', N'admin', 1, N'admin')
INSERT [dbo].[tb_admin] ([adminName], [adminPwd], [ID], [mark]) VALUES (N'wwq', N'123', 3, N'mark')
INSERT [dbo].[tb_admin] ([adminName], [adminPwd], [ID], [mark]) VALUES (N'李洋', N'123456', 5, N'mark')
SET IDENTITY_INSERT [dbo].[tb_admin] OFF
/****** Object:  Table [dbo].[tb_farmer]    Script Date: 11/13/2018 18:48:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_farmer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HuZhuName] [nvarchar](10) NULL,
	[IDCard] [nvarchar](20) NULL,
	[village] [int] NULL,
	[gender] [nvarchar](2) NULL,
	[tel] [nvarchar](20) NULL,
	[pointX] [decimal](18, 10) NULL,
	[pointY] [decimal](18, 10) NULL,
 CONSTRAINT [PK_farmer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_farmer] ON
INSERT [dbo].[tb_farmer] ([ID], [HuZhuName], [IDCard], [village], [gender], [tel], [pointX], [pointY]) VALUES (1, N'王伟强', N'370323199706243019', 9, N'22', N'15621396615', CAST(116.3475078308 AS Decimal(18, 10)), CAST(37.1665242645 AS Decimal(18, 10)))
INSERT [dbo].[tb_farmer] ([ID], [HuZhuName], [IDCard], [village], [gender], [tel], [pointX], [pointY]) VALUES (2, N'李洋', N'9527', 5, N'男', N'110', CAST(116.3200420105 AS Decimal(18, 10)), CAST(37.1801928017 AS Decimal(18, 10)))
INSERT [dbo].[tb_farmer] ([ID], [HuZhuName], [IDCard], [village], [gender], [tel], [pointX], [pointY]) VALUES (4, N'林逸', N'11544', 5, N'男', N'', CAST(116.3143771851 AS Decimal(18, 10)), CAST(37.1800425980 AS Decimal(18, 10)))
INSERT [dbo].[tb_farmer] ([ID], [HuZhuName], [IDCard], [village], [gender], [tel], [pointX], [pointY]) VALUES (6, N'王依然', N'88888', 8, N'女', N'911', CAST(116.3184970581 AS Decimal(18, 10)), CAST(37.1824458572 AS Decimal(18, 10)))
INSERT [dbo].[tb_farmer] ([ID], [HuZhuName], [IDCard], [village], [gender], [tel], [pointX], [pointY]) VALUES (7, N'五六七', N'456321', 8, N'男', N'', NULL, NULL)
SET IDENTITY_INSERT [dbo].[tb_farmer] OFF
/****** Object:  Table [dbo].[tb_basicLand]    Script Date: 11/13/2018 18:48:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_basicLand](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[basicLandCode] [nvarchar](20) NULL,
	[GongZhongRen] [nvarchar](10) NULL,
	[basicLandArea] [decimal](18, 10) NULL,
	[QuanShu] [nvarchar](10) NULL,
	[village] [int] NULL,
	[cultivateYear] [float] NULL,
	[cropType] [nvarchar](20) NULL,
	[irrigateCodition] [nvarchar](10) NULL,
	[polluteConditiom] [nvarchar](10) NULL,
	[pointX] [decimal](18, 10) NULL,
	[pointY] [decimal](18, 10) NULL,
 CONSTRAINT [PK_tb_basicLand] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_basicLand] ON
INSERT [dbo].[tb_basicLand] ([ID], [basicLandCode], [GongZhongRen], [basicLandArea], [QuanShu], [village], [cultivateYear], [cropType], [irrigateCodition], [polluteConditiom], [pointX], [pointY]) VALUES (1, N'555869', N'赵四', CAST(3.0000000000 AS Decimal(18, 10)), N'国家所有', 12, 6, N'粮食作物', N'优', N'高', CAST(116.3575078308 AS Decimal(18, 10)), CAST(37.1665242645 AS Decimal(18, 10)))
INSERT [dbo].[tb_basicLand] ([ID], [basicLandCode], [GongZhongRen], [basicLandArea], [QuanShu], [village], [cultivateYear], [cropType], [irrigateCodition], [polluteConditiom], [pointX], [pointY]) VALUES (3, N'11', N'李洋', CAST(54.0000000000 AS Decimal(18, 10)), N'11', 14, 5, N'杨树', N'', N'', CAST(116.3185399734 AS Decimal(18, 10)), CAST(37.1807077858 AS Decimal(18, 10)))
INSERT [dbo].[tb_basicLand] ([ID], [basicLandCode], [GongZhongRen], [basicLandArea], [QuanShu], [village], [cultivateYear], [cropType], [irrigateCodition], [polluteConditiom], [pointX], [pointY]) VALUES (5, N'555353', N'王伟强', CAST(32.0000000000 AS Decimal(18, 10)), N'国家', 8, NULL, N'', N'', N'', CAST(116.3563276588 AS Decimal(18, 10)), CAST(37.1695444319 AS Decimal(18, 10)))
SET IDENTITY_INSERT [dbo].[tb_basicLand] OFF
/****** Object:  Table [dbo].[tb_illegalEvent]    Script Date: 11/13/2018 18:48:33 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_illegalEvent](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[basicLand] [int] NULL,
	[eventType] [nvarchar](10) NULL,
	[eventContent] [nvarchar](max) NULL,
	[time] [nvarchar](20) NULL,
	[offender] [nvarchar](20) NULL,
	[punishType] [nvarchar](10) NULL,
	[punishContent] [nvarchar](max) NULL,
	[remark] [nvarchar](max) NULL,
 CONSTRAINT [PK_tb_illeglEvent] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tb_illegalEvent] ON
INSERT [dbo].[tb_illegalEvent] ([ID], [basicLand], [eventType], [eventContent], [time], [offender], [punishType], [punishContent], [remark]) VALUES (1, 3, N'利用土地非法盈利', N'', N'09/12/2018', N'11', N'没收非法所得', N'', N'')
INSERT [dbo].[tb_illegalEvent] ([ID], [basicLand], [eventType], [eventContent], [time], [offender], [punishType], [punishContent], [remark]) VALUES (2, 3, N'非法取得土地所有权', N'卖给刘某', N'09/15/2018', N'李洋5', N'罚款', N'', N'')
INSERT [dbo].[tb_illegalEvent] ([ID], [basicLand], [eventType], [eventContent], [time], [offender], [punishType], [punishContent], [remark]) VALUES (4, 3, N'非法转让', N'', N'10/14/2018', N'凌雪', N'罚款', N'', N'')
INSERT [dbo].[tb_illegalEvent] ([ID], [basicLand], [eventType], [eventContent], [time], [offender], [punishType], [punishContent], [remark]) VALUES (5, 3, N'拒不履行义务', N'', N'10/17/2018', N'李白', N'罚款', N'', N'')
INSERT [dbo].[tb_illegalEvent] ([ID], [basicLand], [eventType], [eventContent], [time], [offender], [punishType], [punishContent], [remark]) VALUES (6, 3, N'利用土地非法盈利', N'', N'10/16/2018', N'盖伦', N'无偿收回土地所有权', N'', N'')
SET IDENTITY_INSERT [dbo].[tb_illegalEvent] OFF
/****** Object:  ForeignKey [FK_farmer_tb_village]    Script Date: 11/13/2018 18:48:33 ******/
ALTER TABLE [dbo].[tb_farmer]  WITH CHECK ADD  CONSTRAINT [FK_farmer_tb_village] FOREIGN KEY([village])
REFERENCES [dbo].[tb_village] ([ID])
GO
ALTER TABLE [dbo].[tb_farmer] CHECK CONSTRAINT [FK_farmer_tb_village]
GO
/****** Object:  ForeignKey [FK_tb_basicLand_tb_village]    Script Date: 11/13/2018 18:48:33 ******/
ALTER TABLE [dbo].[tb_basicLand]  WITH CHECK ADD  CONSTRAINT [FK_tb_basicLand_tb_village] FOREIGN KEY([village])
REFERENCES [dbo].[tb_village] ([ID])
GO
ALTER TABLE [dbo].[tb_basicLand] CHECK CONSTRAINT [FK_tb_basicLand_tb_village]
GO
/****** Object:  ForeignKey [FK_tb_illeglEvent_tb_basicLand]    Script Date: 11/13/2018 18:48:33 ******/
ALTER TABLE [dbo].[tb_illegalEvent]  WITH CHECK ADD  CONSTRAINT [FK_tb_illeglEvent_tb_basicLand] FOREIGN KEY([basicLand])
REFERENCES [dbo].[tb_basicLand] ([ID])
GO
ALTER TABLE [dbo].[tb_illegalEvent] CHECK CONSTRAINT [FK_tb_illeglEvent_tb_basicLand]
GO
