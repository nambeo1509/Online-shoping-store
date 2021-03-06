USE [OnlineShoppingSystem]
GO
/****** Object:  Table [dbo].[User]    Script Date: 11/22/2018 23:44:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [bigint] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](150) NULL,
	[Phone] [varchar](50) NULL,
	[Email] [nvarchar](150) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
	[UserName] [varchar](150) NULL,
	[Password] [varchar](150) NULL,
	[Role] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[User] ([UserID], [Name], [Address], [Phone], [Email], [CreatedDate], [ModifiedDate], [UserName], [Password], [Role]) VALUES (1, N'Nguyen Trong Thang', N'495 Bach Dang, Ha Noi', N'01699651560', N'santicazorla@gmail.com', CAST(0x0000A99F00000000 AS DateTime), NULL, N'thangnt17', N'123456', 1)
INSERT [dbo].[User] ([UserID], [Name], [Address], [Phone], [Email], [CreatedDate], [ModifiedDate], [UserName], [Password], [Role]) VALUES (2, N'Nguyen Khanh Linh', N'495 Bach Dang, Ha Noi', N'0963575200', N'linhnk01@gmail.com', CAST(0x0000A99F00000000 AS DateTime), NULL, N'linhnk01', N'123456789', 0)
/****** Object:  Table [dbo].[Category]    Script Date: 11/22/2018 23:44:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [bigint] NOT NULL,
	[CategoryName] [nvarchar](250) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CreatedDate], [ModifiedDate]) VALUES (1, N'ACER', CAST(0x0000A9A000000000 AS DateTime), NULL)
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CreatedDate], [ModifiedDate]) VALUES (2, N'ASUS', CAST(0x0000A9A000000000 AS DateTime), NULL)
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CreatedDate], [ModifiedDate]) VALUES (3, N'DELL', CAST(0x0000A9A000000000 AS DateTime), NULL)
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CreatedDate], [ModifiedDate]) VALUES (4, N'MACBOOK', CAST(0x0000A9A000000000 AS DateTime), NULL)
/****** Object:  Table [dbo].[Order]    Script Date: 11/22/2018 23:44:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [bigint] NOT NULL,
	[CreatedDate] [datetime] NULL,
	[CustomerID] [bigint] NULL,
	[ShipName] [nvarchar](50) NULL,
	[ShipAddress] [nvarchar](50) NULL,
	[ShipMobile] [varchar](50) NULL,
	[ShipEmail] [nvarchar](50) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Products]    Script Date: 11/22/2018 23:44:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductID] [bigint] NOT NULL,
	[ProductName] [nvarchar](250) NULL,
	[Manufacturer] [nvarchar](50) NULL,
	[Description] [nvarchar](500) NULL,
	[Image] [nvarchar](250) NULL,
	[Price] [decimal](18, 0) NULL,
	[Quantity] [int] NOT NULL,
	[CategoryID] [bigint] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
	[Discount] [decimal](18, 0) NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (1, N'Acer A315-51-3932', N'ACER', NULL, N'Acer A315-51-3932.jpg', CAST(8990000 AS Decimal(18, 0)), 20, 1, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (2, N'Acer AS A315-51-325', N'ACER', NULL, N'Acer AS A315-51-325E.jpg', CAST(9390000 AS Decimal(18, 0)), 15, 1, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (3, N'Acer Nitro 5-AN515-52-75FT', N'ACER', NULL, N'Acer Nitro 5-AN515-52-75FT.jpg', CAST(26999000 AS Decimal(18, 0)), 11, 1, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (4, N'Acer Predator Helios 300 PH315-51-759Y', N'ACER', NULL, N'Acer Predator Helios 300 PH315-51-759Y.jpg', CAST(40999000 AS Decimal(18, 0)), 6, 1, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (5, N'Acer Swift SF314-52-55UF', N'ACER', NULL, N'Acer Swift SF314-52-55UF.jpg', CAST(16990000 AS Decimal(18, 0)), 23, 1, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (6, N'Asus ROG GL503GE-EN021Ti7-8750H', N'ASUS', NULL, N'Asus ROG GL503GE-EN021T.jpg', CAST(29990000 AS Decimal(18, 0)), 12, 2, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (7, N'Asus TUF FX504GE-EN047Ti7-8750', N'ASUS', NULL, N'Asus TUF FX504GE-EN047T.jpg', CAST(27490000 AS Decimal(18, 0)), 30, 2, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (8, N'Asus UX430UA-GV344', N'ASUS', NULL, N'Asus UX430UA-GV344.jpg', CAST(18990000 AS Decimal(18, 0)), 16, 2, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (9, N'Asus Vivobook X507UF-EJ074T', N'ASUS', NULL, N'Asus Vivobook X507UF-EJ074T.jpg', CAST(17190000 AS Decimal(18, 0)), 10, 2, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (10, N'Asus Zephyrus M GM501GS-EI004T', N'ASUS', NULL, N'Asus Zephyrus M GM501GS-EI004T.jpg', CAST(64990000 AS Decimal(18, 0)), 4, 2, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (11, N'Dell Inspiron 5570', N'DELL', NULL, N'Dell Inspiron 5570.jpg', CAST(17790000 AS Decimal(18, 0)), 14, 3, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (12, N'Dell N3579', N'DELL', NULL, N'Dell N3579.jpg', CAST(25490000 AS Decimal(18, 0)), 7, 3, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (13, N'Dell V3468', N'DELL', NULL, N'Dell V3468.jpg', CAST(10890000 AS Decimal(18, 0)), 33, 3, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (14, N'Dell Vostro 3578', N'DELL', NULL, N'Dell Vostro 3578.jpg', CAST(18990000 AS Decimal(18, 0)), 15, 3, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (15, N'Dell XPS15', N'DELL', NULL, N'Dell XPS15.jpg', CAST(53990000 AS Decimal(18, 0)), 10, 3, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (16, N'Macbook 12 256GB (2017)', N'MACBOOK', NULL, N'Macbook 12 256GB (2017).jpg', CAST(33990000 AS Decimal(18, 0)), 9, 4, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (17, N'Macbook Air 13 256GB MQD42SAA (2017)', N'MACBOOK', NULL, N'Macbook Air 13 256GB MQD42SAA (2017).jpg', CAST(28990000 AS Decimal(18, 0)), 11, 4, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (18, N'Macbook Pro 13 Touch Bar 256 GB (2018)', N'MACBOOK', NULL, N'Macbook Pro 13 Touch Bar 256 GB (2018).jpg', CAST(44990000 AS Decimal(18, 0)), 12, 4, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (19, N'Macbook Pro 13 inch 128GB (2017)', N'MACBOOK', NULL, N'Macbook Pro 13 inch 128GB (2017).jpg', CAST(33990000 AS Decimal(18, 0)), 4, 4, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
INSERT [dbo].[Products] ([ProductID], [ProductName], [Manufacturer], [Description], [Image], [Price], [Quantity], [CategoryID], [CreatedDate], [ModifiedDate], [Discount]) VALUES (20, N'Macbook Pro 15 Touch Bar 512 GB (2018)', N'MACBOOK', NULL, N'Macbook Pro 15 Touch Bar 512 GB (2018).png', CAST(69990000 AS Decimal(18, 0)), 5, 4, CAST(0x0000A9A000000000 AS DateTime), NULL, NULL)
/****** Object:  Table [dbo].[OrderDetails]    Script Date: 11/22/2018 23:44:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetails](
	[ProductID] [bigint] NOT NULL,
	[OrderID] [bigint] NOT NULL,
	[Quantity] [int] NULL,
	[Price] [decimal](18, 0) NULL,
 CONSTRAINT [PK_OrderDetails] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC,
	[OrderID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Order_User]    Script Date: 11/22/2018 23:44:56 ******/
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_User] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_User]
GO
/****** Object:  ForeignKey [FK_OrderDetails_Order1]    Script Date: 11/22/2018 23:44:56 ******/
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Order1] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Order1]
GO
/****** Object:  ForeignKey [FK_OrderDetails_Products]    Script Date: 11/22/2018 23:44:56 ******/
ALTER TABLE [dbo].[OrderDetails]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetails_Products] FOREIGN KEY([ProductID])
REFERENCES [dbo].[Products] ([ProductID])
GO
ALTER TABLE [dbo].[OrderDetails] CHECK CONSTRAINT [FK_OrderDetails_Products]
GO
/****** Object:  ForeignKey [FK_Products_Category]    Script Date: 11/22/2018 23:44:56 ******/
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Category]
GO
