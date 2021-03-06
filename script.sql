USE [FieldAppDB]
GO
/****** Object:  Table [dbo].[Fields]    Script Date: 26.06.2020 04:45:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fields](
	[FieldsId] [int] NOT NULL,
	[FieldsName] [nvarchar](100) NULL,
	[FieldsPrice] [money] NOT NULL,
	[FieldsCapacity] [int] NULL,
	[isActive] [bit] NULL,
 CONSTRAINT [PK_SahaId] PRIMARY KEY CLUSTERED 
(
	[FieldsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 26.06.2020 04:45:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[OdemeIslemiId] [int] IDENTITY(1,1) NOT NULL,
	[FieldsId] [int] NULL,
	[RezId] [int] NULL,
	[KullaniciId] [int] NULL,
 CONSTRAINT [PK_OdemeIslemiId] PRIMARY KEY CLUSTERED 
(
	[OdemeIslemiId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rezervasyon]    Script Date: 26.06.2020 04:45:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervasyon](
	[RezID] [int] IDENTITY(1,1) NOT NULL,
	[RezNote] [nvarchar](max) NOT NULL,
	[RezAlDate] [nvarchar](50) NOT NULL,
	[RezVeDate] [nvarchar](50) NOT NULL,
	[FieldsId] [int] NOT NULL,
	[Ödendimi] [nvarchar](50) NULL,
 CONSTRAINT [PK_RezID] PRIMARY KEY CLUSTERED 
(
	[RezID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Fields] ([FieldsId], [FieldsName], [FieldsPrice], [FieldsCapacity], [isActive]) VALUES (2, N'asdfas', 33443.0000, 232323, 1)
GO
SET IDENTITY_INSERT [dbo].[Rezervasyon] ON 

INSERT [dbo].[Rezervasyon] ([RezID], [RezNote], [RezAlDate], [RezVeDate], [FieldsId], [Ödendimi]) VALUES (5, N'test', N'26.06.2020 00:00:00', N'26.06.2020 00:00:00', 2, N'Ödendi')
SET IDENTITY_INSERT [dbo].[Rezervasyon] OFF
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_OdemeIslemleri_FieldsId] FOREIGN KEY([FieldsId])
REFERENCES [dbo].[Fields] ([FieldsId])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_OdemeIslemleri_FieldsId]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [FK_OdemeIslemleri_RezId] FOREIGN KEY([RezId])
REFERENCES [dbo].[Rezervasyon] ([RezID])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [FK_OdemeIslemleri_RezId]
GO
ALTER TABLE [dbo].[Rezervasyon]  WITH CHECK ADD  CONSTRAINT [FK_Rezervasyon_FieldsId] FOREIGN KEY([FieldsId])
REFERENCES [dbo].[Fields] ([FieldsId])
GO
ALTER TABLE [dbo].[Rezervasyon] CHECK CONSTRAINT [FK_Rezervasyon_FieldsId]
GO
