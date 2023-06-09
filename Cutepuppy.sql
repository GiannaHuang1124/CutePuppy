USE [CutePuppy]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 2023/4/12 上午 01:16:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](40) NULL,
	[Password] [nvarchar](40) NULL,
	[Gender] [nvarchar](10) NULL,
	[Birthday] [date] NULL,
	[Phone] [nvarchar](24) NULL,
	[Address] [nvarchar](60) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orderlist]    Script Date: 2023/4/12 上午 01:16:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orderlist](
	[OID] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NULL,
	[會員姓名] [nvarchar](40) NULL,
	[收件姓名] [nvarchar](40) NULL,
	[連絡電話] [nvarchar](24) NULL,
	[送貨地址] [nvarchar](100) NULL,
	[出貨進度] [nvarchar](20) NULL,
	[商品名稱] [nvarchar](60) NULL,
	[取貨方式] [nvarchar](20) NULL,
	[付款方式] [nvarchar](20) NULL,
	[出貨日期] [date] NULL,
	[總計金額] [int] NULL,
 CONSTRAINT [PK_Orderlist] PRIMARY KEY CLUSTERED 
(
	[OID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 2023/4/12 上午 01:16:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[pid] [int] IDENTITY(1,1) NOT NULL,
	[pname] [nchar](10) NULL,
	[sellingPrice] [int] NULL,
	[buyPrice] [int] NULL,
	[pdesc] [nvarchar](1000) NULL,
	[pimage] [nvarchar](100) NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[pid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 2023/4/12 上午 01:16:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[SID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](50) NULL,
	[Account] [nchar](50) NULL,
	[Password] [nchar](50) NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustomerID], [Name], [Password], [Gender], [Birthday], [Phone], [Address], [Email]) VALUES (1, N'黃阿真', N'111', N'女', CAST(N'1977-01-26' AS Date), N'0988111111', N'臺中市	南屯區	文心南二路45號10樓之14', N'keith9969@gmail.com
')
INSERT [dbo].[Customer] ([CustomerID], [Name], [Password], [Gender], [Birthday], [Phone], [Address], [Email]) VALUES (2, N'楊舟鈞', N'234', N'女', CAST(N'1964-12-22' AS Date), N'0952144223', N'嘉義縣竹崎鄉北勢坑20號3樓', N'mulligan216@yahoo.com')
INSERT [dbo].[Customer] ([CustomerID], [Name], [Password], [Gender], [Birthday], [Phone], [Address], [Email]) VALUES (3, N'王林蓁', N'123', N'男', CAST(N'1973-10-08' AS Date), N'0987444562', N'臺南市	關廟區	中山路１段60號4樓', N'becca7733@gmail.com')
INSERT [dbo].[Customer] ([CustomerID], [Name], [Password], [Gender], [Birthday], [Phone], [Address], [Email]) VALUES (4, N'袁承謙
', N'111', N'女', CAST(N'1980-12-14' AS Date), N'0981442351', N'新竹縣芎林鄉燥坑72號', N'reynes7536@gmail.com')
INSERT [dbo].[Customer] ([CustomerID], [Name], [Password], [Gender], [Birthday], [Phone], [Address], [Email]) VALUES (6, N'陳宸葉
', N'567', N'男', CAST(N'1961-04-01' AS Date), N'09273336345', N'臺南市	麻豆區	中正路21號', N'vera6801@gmail.com')
INSERT [dbo].[Customer] ([CustomerID], [Name], [Password], [Gender], [Birthday], [Phone], [Address], [Email]) VALUES (8, N'葉子齊', N'678', N'男', CAST(N'1991-03-23' AS Date), N'0927364523', N'屏東縣內埔鄉文山路5號之15', N'dennis3403@gmail.com')
INSERT [dbo].[Customer] ([CustomerID], [Name], [Password], [Gender], [Birthday], [Phone], [Address], [Email]) VALUES (11, N'李輝馨
', N'789', N'女', CAST(N'1989-05-08' AS Date), N'09162534765', N'新竹縣	新豐鄉	青埔子60號7樓之14', N'oliver9896@icloud.com')
INSERT [dbo].[Customer] ([CustomerID], [Name], [Password], [Gender], [Birthday], [Phone], [Address], [Email]) VALUES (13, N'謝津芮', N'123', N'男', CAST(N'1982-03-22' AS Date), N'0934633444', N'彰化縣	溪州鄉	中央路３段73號12樓', N'gerson5010@gmail.com')
INSERT [dbo].[Customer] ([CustomerID], [Name], [Password], [Gender], [Birthday], [Phone], [Address], [Email]) VALUES (15, N'測試員', N'111', N'男', CAST(N'1979-08-04' AS Date), N'0963120471', N'高雄市三民區自重街87號5樓', N'ward7512@gmail.com')
INSERT [dbo].[Customer] ([CustomerID], [Name], [Password], [Gender], [Birthday], [Phone], [Address], [Email]) VALUES (18, N'陳勵懷', N'111', N'男', CAST(N'1967-08-07' AS Date), N'0982334124', N'雲林縣北港鎮義民路13號', N'mikaela8107@hotmail.com')
SET IDENTITY_INSERT [dbo].[Customer] OFF
GO
SET IDENTITY_INSERT [dbo].[Orderlist] ON 

INSERT [dbo].[Orderlist] ([OID], [CustomerID], [會員姓名], [收件姓名], [連絡電話], [送貨地址], [出貨進度], [商品名稱], [取貨方式], [付款方式], [出貨日期], [總計金額]) VALUES (1, 1, N'黃阿真', N'韓宥藍', N'0988534222', N'臺中市	南屯區	文心南二路45號10樓之14', N'未出貨', N'蒙古包寵物窩    ', N'宅配', N'信用卡', CAST(N'2022-10-05' AS Date), 880)
INSERT [dbo].[Orderlist] ([OID], [CustomerID], [會員姓名], [收件姓名], [連絡電話], [送貨地址], [出貨進度], [商品名稱], [取貨方式], [付款方式], [出貨日期], [總計金額]) VALUES (2, 2, N'楊舟鈞', N'黃涵雅', N'0928374625', N'嘉義縣竹崎鄉北勢坑20號3樓', N'出貨中', N'披薩寵物墊     ', N'超商取貨', N'ATM轉帳', CAST(N'2022-11-20' AS Date), 430)
INSERT [dbo].[Orderlist] ([OID], [CustomerID], [會員姓名], [收件姓名], [連絡電話], [送貨地址], [出貨進度], [商品名稱], [取貨方式], [付款方式], [出貨日期], [總計金額]) VALUES (3, 3, N'王林蓁', N'謝津芮', N'0972334533', N'臺南市	關廟區	中山路１段60號4樓', N'已送達', N'原木托高碗架    ', N'宅配', N'ATM轉帳', CAST(N'2022-12-03' AS Date), 1460)
INSERT [dbo].[Orderlist] ([OID], [CustomerID], [會員姓名], [收件姓名], [連絡電話], [送貨地址], [出貨進度], [商品名稱], [取貨方式], [付款方式], [出貨日期], [總計金額]) VALUES (4, 4, N'袁承謙
', N'蔣泓進', N'0928453355', N'新竹縣芎林鄉燥坑72號', N'未出貨', N'木棉床', N'宅配', N'信用卡', CAST(N'2022-12-06' AS Date), 200)
INSERT [dbo].[Orderlist] ([OID], [CustomerID], [會員姓名], [收件姓名], [連絡電話], [送貨地址], [出貨進度], [商品名稱], [取貨方式], [付款方式], [出貨日期], [總計金額]) VALUES (5, 8, N'葉子齊', N'葉子齊', N'0963120471', N'屏東縣內埔鄉文山路5號之15', N'未出貨', N'原木托高碗架    ', N'宅配', N'信用卡', CAST(N'2022-12-06' AS Date), 1380)
INSERT [dbo].[Orderlist] ([OID], [CustomerID], [會員姓名], [收件姓名], [連絡電話], [送貨地址], [出貨進度], [商品名稱], [取貨方式], [付款方式], [出貨日期], [總計金額]) VALUES (6, 3, N'王林蓁', N'王林蓁', N'0972334533', N'屏東縣內埔鄉文山路5號之15', N'未出貨', N'披薩寵物墊     ', N'宅配', N'信用卡', CAST(N'2022-12-06' AS Date), 350)
INSERT [dbo].[Orderlist] ([OID], [CustomerID], [會員姓名], [收件姓名], [連絡電話], [送貨地址], [出貨進度], [商品名稱], [取貨方式], [付款方式], [出貨日期], [總計金額]) VALUES (7, 15, N'顏慧梅', N'顏慧梅', N'0963120471', N'高雄市三民區自重街87號5樓', N'未出貨', N'蒙古包寵物窩    ', N'宅配', N'信用卡', CAST(N'2022-12-06' AS Date), 800)
SET IDENTITY_INSERT [dbo].[Orderlist] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([pid], [pname], [sellingPrice], [buyPrice], [pdesc], [pimage]) VALUES (1, N'蒙古包寵物窩    ', 800, 200, N'造型可愛 溫馨溫暖
短絨好清洗 寶貝愛躲藏', N'1.jpg')
INSERT [dbo].[products] ([pid], [pname], [sellingPrice], [buyPrice], [pdesc], [pimage]) VALUES (2, N'披薩寵物墊     ', 350, 100, N'各種造型可選 逼真趣味
擬真細緻印刷 趣味造型
雙面絨布 觸感細緻
貓狗兔子多種寵物皆可
', N'2.jpg')
INSERT [dbo].[products] ([pid], [pname], [sellingPrice], [buyPrice], [pdesc], [pimage]) VALUES (3, N'原木托高碗架    ', 1380, 350, N'托高傾斜的設計、減緩寶貝頸椎壓力，讓每一口進食更多安穩、更加舒適', N'3.jpg')
INSERT [dbo].[products] ([pid], [pname], [sellingPrice], [buyPrice], [pdesc], [pimage]) VALUES (4, N'木棉床       ', 3000, 500, N'透過溫潤的木材，為寵物設計舒適的木眠床，給毛孩專屬睡眠空間，輕鬆酣甜入夢，融入各種居家氛圍，讓居家質感瞬間升級。
', N'4.jpg')
INSERT [dbo].[products] ([pid], [pname], [sellingPrice], [buyPrice], [pdesc], [pimage]) VALUES (5, N'護目鏡       ', 2980, 600, N'本商品包含一副鏡架＆兩副鏡片(透明＆墨色)

鏡片皆為99% 抗UV', N'5.jpg')
INSERT [dbo].[products] ([pid], [pname], [sellingPrice], [buyPrice], [pdesc], [pimage]) VALUES (7, N'不倒翁餵食器    ', 180, 50, N'輕輕一推開始漏食
二合一吃食加玩樂
訓練你寶貝的智商', N'6.jpg')
INSERT [dbo].[products] ([pid], [pname], [sellingPrice], [buyPrice], [pdesc], [pimage]) VALUES (8, N'摺疊收納階梯    ', 736, 230, N'韓國WOOLLY 寵物樓梯 保護毛孩關節
實用收納空間 收藏零食或玩具 樓梯蓋子內襯海綿 狗狗行走無負擔', N'7.jpg')
INSERT [dbo].[products] ([pid], [pname], [sellingPrice], [buyPrice], [pdesc], [pimage]) VALUES (1008, N'1         ', 1, 1, N'1', N'202212161916501041.jpg')
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[Staff] ON 

INSERT [dbo].[Staff] ([SID], [Name], [Account], [Password]) VALUES (1, N'管理員                                               ', N'aaa                                               ', N'111                                               ')
INSERT [dbo].[Staff] ([SID], [Name], [Account], [Password]) VALUES (2, N'黃阿真                                               ', N'Gianna                                            ', N'111                                               ')
SET IDENTITY_INSERT [dbo].[Staff] OFF
GO
ALTER TABLE [dbo].[Orderlist]  WITH CHECK ADD  CONSTRAINT [FK_Orderlist_Orderlist] FOREIGN KEY([OID])
REFERENCES [dbo].[Orderlist] ([OID])
GO
ALTER TABLE [dbo].[Orderlist] CHECK CONSTRAINT [FK_Orderlist_Orderlist]
GO
