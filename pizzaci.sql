USE [pizzaci]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 25.12.2019 13:34:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[admin_id] [int] IDENTITY(1,1) NOT NULL,
	[kullanici_ad] [nvarchar](20) NOT NULL,
	[admin_ad] [nvarchar](20) NOT NULL,
	[admin_soyad] [nvarchar](20) NOT NULL,
	[sifre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[admin_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Boyut]    Script Date: 25.12.2019 13:34:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Boyut](
	[boyut_id] [int] IDENTITY(1,1) NOT NULL,
	[boyut_ad] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Boyut] PRIMARY KEY CLUSTERED 
(
	[boyut_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[İcecekler]    Script Date: 25.12.2019 13:34:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[İcecekler](
	[icecek_id] [int] IDENTITY(1,1) NOT NULL,
	[icecek_ad] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_İcecekler] PRIMARY KEY CLUSTERED 
(
	[icecek_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Malzemeler]    Script Date: 25.12.2019 13:34:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Malzemeler](
	[malzeme_id] [int] IDENTITY(1,1) NOT NULL,
	[malzeme_ad] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Malzemeler] PRIMARY KEY CLUSTERED 
(
	[malzeme_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteri]    Script Date: 25.12.2019 13:34:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteri](
	[musteri_id] [int] IDENTITY(1,1) NOT NULL,
	[musteri_ad] [nvarchar](15) NOT NULL,
	[musteri_soyad] [nvarchar](15) NOT NULL,
	[musteri_adres] [nvarchar](max) NOT NULL,
	[musteri_tel] [nvarchar](15) NULL,
 CONSTRAINT [PK_Musteri] PRIMARY KEY CLUSTERED 
(
	[musteri_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Secenekler]    Script Date: 25.12.2019 13:34:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Secenekler](
	[secenek_id] [int] IDENTITY(1,1) NOT NULL,
	[secenek_ad] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Secenekler] PRIMARY KEY CLUSTERED 
(
	[secenek_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SilinenMusteriler]    Script Date: 25.12.2019 13:34:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SilinenMusteriler](
	[musteriID] [int] IDENTITY(1,1) NOT NULL,
	[musteriAd] [nvarchar](15) NOT NULL,
	[musteriSoyad] [nvarchar](15) NOT NULL,
	[musteriAdres] [nvarchar](max) NOT NULL,
	[musteriTel] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_SilinenMusteriler] PRIMARY KEY CLUSTERED 
(
	[musteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siparis]    Script Date: 25.12.2019 13:34:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparis](
	[siparis_id] [int] IDENTITY(1,1) NOT NULL,
	[musteri_id] [int] NOT NULL,
	[boyut_id] [int] NOT NULL,
	[secenek_id] [int] NOT NULL,
	[sos_id] [int] NOT NULL,
	[icecek_id] [int] NOT NULL,
 CONSTRAINT [PK_Siparis] PRIMARY KEY CLUSTERED 
(
	[siparis_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Siparis_Malzeme]    Script Date: 25.12.2019 13:34:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Siparis_Malzeme](
	[Siparis_Id] [int] NULL,
	[Malzeme_Id] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Soslar]    Script Date: 25.12.2019 13:34:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Soslar](
	[sos_id] [int] IDENTITY(1,1) NOT NULL,
	[sos_ad] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Soslar] PRIMARY KEY CLUSTERED 
(
	[sos_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Admin] ON 

INSERT [dbo].[Admin] ([admin_id], [kullanici_ad], [admin_ad], [admin_soyad], [sifre]) VALUES (1, N'ebruyildirim', N'Ebru', N'Yıldırım', N'1')
INSERT [dbo].[Admin] ([admin_id], [kullanici_ad], [admin_ad], [admin_soyad], [sifre]) VALUES (2, N'aleynacalkin', N'Aleyna', N'Çalkın', N'2         ')
INSERT [dbo].[Admin] ([admin_id], [kullanici_ad], [admin_ad], [admin_soyad], [sifre]) VALUES (3, N'seymanurtpl', N'Şeymanur', N'Topal', N'3         ')
INSERT [dbo].[Admin] ([admin_id], [kullanici_ad], [admin_ad], [admin_soyad], [sifre]) VALUES (4, N'akali', N'Ali', N'Ak', N'15')
INSERT [dbo].[Admin] ([admin_id], [kullanici_ad], [admin_ad], [admin_soyad], [sifre]) VALUES (5, N'tasveli', N'Veli', N'Taş', N'10')
INSERT [dbo].[Admin] ([admin_id], [kullanici_ad], [admin_ad], [admin_soyad], [sifre]) VALUES (6, N'selimtas', N'Selim', N'Taş', N'9')
SET IDENTITY_INSERT [dbo].[Admin] OFF
SET IDENTITY_INSERT [dbo].[Boyut] ON 

INSERT [dbo].[Boyut] ([boyut_id], [boyut_ad]) VALUES (1, N'Küçük Boy ')
INSERT [dbo].[Boyut] ([boyut_id], [boyut_ad]) VALUES (2, N'Orta Boy  ')
INSERT [dbo].[Boyut] ([boyut_id], [boyut_ad]) VALUES (3, N'Büyük Boy ')
SET IDENTITY_INSERT [dbo].[Boyut] OFF
SET IDENTITY_INSERT [dbo].[İcecekler] ON 

INSERT [dbo].[İcecekler] ([icecek_id], [icecek_ad]) VALUES (2, N'Su')
INSERT [dbo].[İcecekler] ([icecek_id], [icecek_ad]) VALUES (4, N'Soda')
INSERT [dbo].[İcecekler] ([icecek_id], [icecek_ad]) VALUES (6, N'Ayran')
INSERT [dbo].[İcecekler] ([icecek_id], [icecek_ad]) VALUES (7, N'Karışık Meyve Suyu')
INSERT [dbo].[İcecekler] ([icecek_id], [icecek_ad]) VALUES (8, N'Vişneli Meyve Suyu')
INSERT [dbo].[İcecekler] ([icecek_id], [icecek_ad]) VALUES (9, N'Kola')
INSERT [dbo].[İcecekler] ([icecek_id], [icecek_ad]) VALUES (10, N'Limonlu Maden Suyu')
INSERT [dbo].[İcecekler] ([icecek_id], [icecek_ad]) VALUES (11, N'Çilekli Maden Suyu')
INSERT [dbo].[İcecekler] ([icecek_id], [icecek_ad]) VALUES (12, N'Limonlu Soğuk Çay')
INSERT [dbo].[İcecekler] ([icecek_id], [icecek_ad]) VALUES (13, N'Şeftalili Soğuk Çay')
INSERT [dbo].[İcecekler] ([icecek_id], [icecek_ad]) VALUES (14, N'Gazoz')
SET IDENTITY_INSERT [dbo].[İcecekler] OFF
SET IDENTITY_INSERT [dbo].[Malzemeler] ON 

INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (1, N'Zeytin')
INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (2, N'Domates')
INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (3, N'Biber')
INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (4, N'Mısır')
INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (5, N'Sosis')
INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (6, N'Salam')
INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (7, N'Sucuk')
INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (8, N'Mozarella')
INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (9, N'Cheddar')
INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (10, N'Mantar')
INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (11, N'Kekik')
INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (12, N'Jambon')
INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (13, N'Pastırma')
INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (14, N'Soğan')
INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (15, N'Sarımsak')
INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (16, N'Kaşar')
INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (17, N'Susam')
INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (18, N'Kavurma')
INSERT [dbo].[Malzemeler] ([malzeme_id], [malzeme_ad]) VALUES (19, N'Tavuk')
SET IDENTITY_INSERT [dbo].[Malzemeler] OFF
SET IDENTITY_INSERT [dbo].[Musteri] ON 

INSERT [dbo].[Musteri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_adres], [musteri_tel]) VALUES (3, N'Doğuş', N'Yıldırım', N'Atatürk mah. no:12 ', N'(543) 765-8080')
INSERT [dbo].[Musteri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_adres], [musteri_tel]) VALUES (4, N'İlkhan', N'Kılıç', N'Merkez mah. no:56', N'(543) 678-7070')
INSERT [dbo].[Musteri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_adres], [musteri_tel]) VALUES (5, N'Cemil ', N'Akbaş', N'Uzunmustafa mah. no:6', N'(543) 234-6060')
INSERT [dbo].[Musteri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_adres], [musteri_tel]) VALUES (6, N'Sena', N'Aydın', N'Nusrettin mah. no:32', N'(537) 890-6543')
INSERT [dbo].[Musteri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_adres], [musteri_tel]) VALUES (7, N'Ebru', N'Aksu', N'Uzunmustafa mah. yılmaz sk. no:67', N'(543) 543-7676')
INSERT [dbo].[Musteri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_adres], [musteri_tel]) VALUES (18, N'retre', N'gfhgf', N'ruııuhuı', N'(333) 333-3333')
INSERT [dbo].[Musteri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_adres], [musteri_tel]) VALUES (33, N'Merve', N'AKSU', N'mhgdgvh', N'(543) 987-7667')
INSERT [dbo].[Musteri] ([musteri_id], [musteri_ad], [musteri_soyad], [musteri_adres], [musteri_tel]) VALUES (34, N'merve', N'aksu', N'dsıfhuıdj', N'(111) 111-1111')
SET IDENTITY_INSERT [dbo].[Musteri] OFF
SET IDENTITY_INSERT [dbo].[Secenekler] ON 

INSERT [dbo].[Secenekler] ([secenek_id], [secenek_ad]) VALUES (1, N'Mantarlı')
INSERT [dbo].[Secenekler] ([secenek_id], [secenek_ad]) VALUES (2, N'Ton Balıklı')
INSERT [dbo].[Secenekler] ([secenek_id], [secenek_ad]) VALUES (3, N'Sucuklu')
INSERT [dbo].[Secenekler] ([secenek_id], [secenek_ad]) VALUES (4, N'Tavuklu')
INSERT [dbo].[Secenekler] ([secenek_id], [secenek_ad]) VALUES (5, N'Kaşarlı')
INSERT [dbo].[Secenekler] ([secenek_id], [secenek_ad]) VALUES (6, N'Çikolatalı')
INSERT [dbo].[Secenekler] ([secenek_id], [secenek_ad]) VALUES (7, N'Mozzarella Peynirli ')
INSERT [dbo].[Secenekler] ([secenek_id], [secenek_ad]) VALUES (8, N'Pastırmalı')
SET IDENTITY_INSERT [dbo].[Secenekler] OFF
SET IDENTITY_INSERT [dbo].[SilinenMusteriler] ON 

INSERT [dbo].[SilinenMusteriler] ([musteriID], [musteriAd], [musteriSoyad], [musteriAdres], [musteriTel]) VALUES (2, N'aslı', N'yılmaz', N'jfıhgkdfj', N'(999) 999-9999')
INSERT [dbo].[SilinenMusteriler] ([musteriID], [musteriAd], [musteriSoyad], [musteriAdres], [musteriTel]) VALUES (3, N'b', N'b', N'b', N'(555) 555-5555')
INSERT [dbo].[SilinenMusteriler] ([musteriID], [musteriAd], [musteriSoyad], [musteriAdres], [musteriTel]) VALUES (4, N'bjkhkhj', N'b', N'b', N'(111) 111-1111')
INSERT [dbo].[SilinenMusteriler] ([musteriID], [musteriAd], [musteriSoyad], [musteriAdres], [musteriTel]) VALUES (5, N'b', N'b', N'u', N'(444) 444-4444')
INSERT [dbo].[SilinenMusteriler] ([musteriID], [musteriAd], [musteriSoyad], [musteriAdres], [musteriTel]) VALUES (6, N'Emre', N'f', N'ftrhytfr', N'(666) 666-6666')
SET IDENTITY_INSERT [dbo].[SilinenMusteriler] OFF
SET IDENTITY_INSERT [dbo].[Siparis] ON 

INSERT [dbo].[Siparis] ([siparis_id], [musteri_id], [boyut_id], [secenek_id], [sos_id], [icecek_id]) VALUES (5, 4, 2, 3, 3, 6)
INSERT [dbo].[Siparis] ([siparis_id], [musteri_id], [boyut_id], [secenek_id], [sos_id], [icecek_id]) VALUES (6, 5, 1, 8, 4, 2)
INSERT [dbo].[Siparis] ([siparis_id], [musteri_id], [boyut_id], [secenek_id], [sos_id], [icecek_id]) VALUES (7, 6, 3, 5, 5, 10)
INSERT [dbo].[Siparis] ([siparis_id], [musteri_id], [boyut_id], [secenek_id], [sos_id], [icecek_id]) VALUES (8, 3, 3, 4, 2, 11)
INSERT [dbo].[Siparis] ([siparis_id], [musteri_id], [boyut_id], [secenek_id], [sos_id], [icecek_id]) VALUES (10, 18, 2, 4, 4, 7)
INSERT [dbo].[Siparis] ([siparis_id], [musteri_id], [boyut_id], [secenek_id], [sos_id], [icecek_id]) VALUES (11, 18, 2, 4, 4, 7)
INSERT [dbo].[Siparis] ([siparis_id], [musteri_id], [boyut_id], [secenek_id], [sos_id], [icecek_id]) VALUES (12, 18, 2, 4, 4, 7)
INSERT [dbo].[Siparis] ([siparis_id], [musteri_id], [boyut_id], [secenek_id], [sos_id], [icecek_id]) VALUES (22, 34, 2, 3, 3, 6)
SET IDENTITY_INSERT [dbo].[Siparis] OFF
INSERT [dbo].[Siparis_Malzeme] ([Siparis_Id], [Malzeme_Id]) VALUES (5, 1)
INSERT [dbo].[Siparis_Malzeme] ([Siparis_Id], [Malzeme_Id]) VALUES (5, 2)
INSERT [dbo].[Siparis_Malzeme] ([Siparis_Id], [Malzeme_Id]) VALUES (5, 4)
INSERT [dbo].[Siparis_Malzeme] ([Siparis_Id], [Malzeme_Id]) VALUES (6, 2)
INSERT [dbo].[Siparis_Malzeme] ([Siparis_Id], [Malzeme_Id]) VALUES (6, 3)
INSERT [dbo].[Siparis_Malzeme] ([Siparis_Id], [Malzeme_Id]) VALUES (7, 4)
INSERT [dbo].[Siparis_Malzeme] ([Siparis_Id], [Malzeme_Id]) VALUES (7, 5)
INSERT [dbo].[Siparis_Malzeme] ([Siparis_Id], [Malzeme_Id]) VALUES (8, 11)
INSERT [dbo].[Siparis_Malzeme] ([Siparis_Id], [Malzeme_Id]) VALUES (8, 10)
INSERT [dbo].[Siparis_Malzeme] ([Siparis_Id], [Malzeme_Id]) VALUES (22, 4)
INSERT [dbo].[Siparis_Malzeme] ([Siparis_Id], [Malzeme_Id]) VALUES (22, 5)
INSERT [dbo].[Siparis_Malzeme] ([Siparis_Id], [Malzeme_Id]) VALUES (22, 6)
INSERT [dbo].[Siparis_Malzeme] ([Siparis_Id], [Malzeme_Id]) VALUES (22, 7)
SET IDENTITY_INSERT [dbo].[Soslar] ON 

INSERT [dbo].[Soslar] ([sos_id], [sos_ad]) VALUES (1, N'Ketçap    ')
INSERT [dbo].[Soslar] ([sos_id], [sos_ad]) VALUES (2, N'Mayonez   ')
INSERT [dbo].[Soslar] ([sos_id], [sos_ad]) VALUES (3, N'Hardal    ')
INSERT [dbo].[Soslar] ([sos_id], [sos_ad]) VALUES (4, N'Acı Sos   ')
INSERT [dbo].[Soslar] ([sos_id], [sos_ad]) VALUES (5, N'Barbekü Sos')
INSERT [dbo].[Soslar] ([sos_id], [sos_ad]) VALUES (6, N'Ranch Sos')
INSERT [dbo].[Soslar] ([sos_id], [sos_ad]) VALUES (7, N'Sarımsaklı Mayonez')
SET IDENTITY_INSERT [dbo].[Soslar] OFF
ALTER TABLE [dbo].[Siparis]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_Boyut] FOREIGN KEY([boyut_id])
REFERENCES [dbo].[Boyut] ([boyut_id])
GO
ALTER TABLE [dbo].[Siparis] CHECK CONSTRAINT [FK_Siparis_Boyut]
GO
ALTER TABLE [dbo].[Siparis]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_İcecekler] FOREIGN KEY([icecek_id])
REFERENCES [dbo].[İcecekler] ([icecek_id])
GO
ALTER TABLE [dbo].[Siparis] CHECK CONSTRAINT [FK_Siparis_İcecekler]
GO
ALTER TABLE [dbo].[Siparis]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_Musteri] FOREIGN KEY([musteri_id])
REFERENCES [dbo].[Musteri] ([musteri_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Siparis] CHECK CONSTRAINT [FK_Siparis_Musteri]
GO
ALTER TABLE [dbo].[Siparis]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_Secenekler] FOREIGN KEY([secenek_id])
REFERENCES [dbo].[Secenekler] ([secenek_id])
GO
ALTER TABLE [dbo].[Siparis] CHECK CONSTRAINT [FK_Siparis_Secenekler]
GO
ALTER TABLE [dbo].[Siparis]  WITH CHECK ADD  CONSTRAINT [FK_Siparis_Soslar] FOREIGN KEY([sos_id])
REFERENCES [dbo].[Soslar] ([sos_id])
GO
ALTER TABLE [dbo].[Siparis] CHECK CONSTRAINT [FK_Siparis_Soslar]
GO
ALTER TABLE [dbo].[Siparis_Malzeme]  WITH CHECK ADD FOREIGN KEY([Malzeme_Id])
REFERENCES [dbo].[Malzemeler] ([malzeme_id])
GO
ALTER TABLE [dbo].[Siparis_Malzeme]  WITH CHECK ADD  CONSTRAINT [FK__Siparis_M__Sipar__3E1D39E1] FOREIGN KEY([Siparis_Id])
REFERENCES [dbo].[Siparis] ([siparis_id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Siparis_Malzeme] CHECK CONSTRAINT [FK__Siparis_M__Sipar__3E1D39E1]
GO
