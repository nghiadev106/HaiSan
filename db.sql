USE [HaiSan]
GO
/****** Object:  UserDefinedFunction [dbo].[fuConvertToUnsign1]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[fuConvertToUnsign1] ( @strInput NVARCHAR(4000) ) RETURNS NVARCHAR(4000) AS BEGIN IF @strInput IS NULL RETURN @strInput IF @strInput = '' RETURN @strInput DECLARE @RT NVARCHAR(4000) DECLARE @SIGN_CHARS NCHAR(136) DECLARE @UNSIGN_CHARS NCHAR (136) SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee iiiiiooooooooooooooouuuuuuuuuuyyyyy AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' DECLARE @COUNTER int DECLARE @COUNTER1 int SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = replace(@strInput,' ','-') RETURN @strInput END
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CategoriesNew]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoriesNew](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[Description] [nvarchar](500) NULL,
	[Url] [nchar](10) NULL,
	[DisplayOrder] [int] NULL,
	[CreateDate] [datetime] NULL,
	[ShowHome] [bit] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_CategoriesNew] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[ParentId] [bigint] NULL,
	[Description] [nvarchar](500) NULL,
	[Url] [nvarchar](500) NULL,
	[DisplayOrder] [int] NULL,
	[CreateDate] [datetime] NULL,
	[ShowHome] [bit] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Contact]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contact](
	[Id] [bigint] NOT NULL,
	[Name] [nvarchar](500) NULL,
	[Phone] [nvarchar](500) NULL,
	[Email] [nvarchar](500) NULL,
	[Content] [text] NULL,
	[Status] [int] NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Contact] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[News]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[News](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[CategoryId] [bigint] NULL,
	[Logo] [nvarchar](500) NULL,
	[Description] [nvarchar](max) NULL,
	[Detail] [nvarchar](max) NULL,
	[IsNew] [bit] NULL,
	[CreateDate] [datetime] NULL,
	[EditDate] [datetime] NULL,
	[Url] [nvarchar](250) NULL,
	[DisplayOrder] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_News] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[OrderName] [nvarchar](500) NOT NULL,
	[OrderAddress] [nvarchar](500) NOT NULL,
	[OrderEmail] [nvarchar](500) NULL,
	[OrderPhone] [int] NOT NULL,
	[OrderNote] [nvarchar](500) NULL,
	[TotalMoney] [decimal](18, 0) NULL,
	[PaymentStatus] [int] NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[OrderId] [bigint] NOT NULL,
	[ProductId] [bigint] NOT NULL,
	[Price] [decimal](18, 0) NULL,
	[Quantity] [int] NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_OrderDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](500) NULL,
	[CategoryId] [bigint] NULL,
	[Logo] [nvarchar](500) NULL,
	[Description] [nvarchar](max) NULL,
	[Detail] [nvarchar](max) NULL,
	[Price] [decimal](18, 0) NULL,
	[PriceDiscount] [decimal](18, 0) NULL,
	[IsNew] [bit] NULL,
	[CreateDate] [datetime] NULL,
	[EditDate] [datetime] NULL,
	[Url] [nvarchar](250) NULL,
	[DisplayOrder] [int] NULL,
	[Status] [int] NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Promotion]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Promotion](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Logo] [nvarchar](250) NULL,
	[Link] [nvarchar](250) NULL,
	[Status] [int] NULL,
	[DisplayOrder] [int] NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Promotion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Setting]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Setting](
	[Logo] [nchar](10) NULL,
	[Hotline1] [nchar](10) NULL,
	[Hotline2] [nchar](10) NULL,
	[Info] [nchar](10) NULL,
	[Address] [nchar](10) NULL,
	[Facebook] [nchar](10) NULL,
	[Zalo] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Slides]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Slides](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Logo] [nvarchar](250) NULL,
	[Link] [nvarchar](250) NULL,
	[Status] [int] NULL,
	[DisplayOrder] [int] NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_Slides] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TopMenu]    Script Date: 06/06/2022 15:04:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TopMenu](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Logo] [nvarchar](250) NULL,
	[Link] [nvarchar](250) NULL,
	[Status] [int] NULL,
	[DisplayOrder] [int] NULL,
	[CreateDate] [datetime] NULL,
 CONSTRAINT [PK_TopMenu] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'3.1.14')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'450db95e-f81e-45be-94ff-c0f85971bff8', N'nghiadv1006@gmail.com', N'NGHIADV1006@GMAIL.COM', N'nghiadv1006@gmail.com', N'NGHIADV1006@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEO7pp2dNIbwsGORDl8dknLkjh2tOLa18uV5cKf2hcMdj0JIfX5RS9F5MmdronhOn8g==', N'YG3JYPI34SZW5OAWXYC5HNUAGSABE4JW', N'a0d2f40d-332b-4fde-b242-b36756863b0e', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'630a4bea-2ceb-46ab-b26d-0854287bf13c', N'admin', N'ADMIN', N'admin@gmail.com', N'admin@gmail.com', 1, N'AQAAAAEAACcQAAAAEDVVxU5cqemmkrHx2w7DXR3pSfWcVsm9I0MO+ykCl7NAcXhhfP7Hl5wgaTkSJP85uA==', N'UQUDWAPTGCCH6GAA3ZT6CXR4RKDQA6BX', N'74342c66-d5f1-4ad7-b80c-1df22c2d1c9f', NULL, 0, 0, NULL, 1, 0)
GO
SET IDENTITY_INSERT [dbo].[CategoriesNew] ON 

INSERT [dbo].[CategoriesNew] ([Id], [Name], [Description], [Url], [DisplayOrder], [CreateDate], [ShowHome], [Status]) VALUES (1, N'Khuyến mãi', N'có', N'khuyen-mai', 1, CAST(N'2021-09-06T19:03:49.833' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[CategoriesNew] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name], [ParentId], [Description], [Url], [DisplayOrder], [CreateDate], [ShowHome], [Status]) VALUES (34, N'Cá tươi', 0, N'Hoa tình yêu - shop hoa đẹp tại Hưng Yên', N'ca-tuoi', 1, CAST(N'2021-09-03T22:37:53.220' AS DateTime), 1, 1)
INSERT [dbo].[Category] ([Id], [Name], [ParentId], [Description], [Url], [DisplayOrder], [CreateDate], [ShowHome], [Status]) VALUES (35, N'Tôm tươi', 0, N'Hoa sinh nhật', N'tom-tuoi', 2, CAST(N'2021-09-03T23:12:15.517' AS DateTime), 1, 1)
INSERT [dbo].[Category] ([Id], [Name], [ParentId], [Description], [Url], [DisplayOrder], [CreateDate], [ShowHome], [Status]) VALUES (36, N'Mực tươi', 0, N'Bình hoa sang trọng', N'muc-tuoi', 3, CAST(N'2021-09-03T23:13:41.160' AS DateTime), 1, 1)
INSERT [dbo].[Category] ([Id], [Name], [ParentId], [Description], [Url], [DisplayOrder], [CreateDate], [ShowHome], [Status]) VALUES (37, N'Ngao, xò, ốc', 0, N'Giỏ hoa tươi', N'ngao-xo-oc', 4, CAST(N'2021-09-03T23:14:32.157' AS DateTime), 1, 1)
INSERT [dbo].[Category] ([Id], [Name], [ParentId], [Description], [Url], [DisplayOrder], [CreateDate], [ShowHome], [Status]) VALUES (38, N'Cua - ghẹ', 0, N'Lẵng hoa chúc mừng', N'lang-hoa-chuc-mung', 5, CAST(N'2021-09-03T23:16:29.163' AS DateTime), 1, 1)
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[News] ON 

INSERT [dbo].[News] ([Id], [Name], [CategoryId], [Logo], [Description], [Detail], [IsNew], [CreateDate], [EditDate], [Url], [DisplayOrder], [Status]) VALUES (2, N'bai viet 1', 1, N'/uploads/73d39565-fae8-40cc-9b81-003bea722f2e.png', N'ko', N'<div id="input_line_0" style="padding-top: 5px; color: rgb(0, 26, 51); font-family: &quot;Segoe UI&quot;, SegoeuiPc, &quot;San Francisco&quot;, &quot;Helvetica Neue&quot;, Helvetica, &quot;Lucida Grande&quot;, Roboto, Ubuntu, Tahoma, &quot;Microsoft Sans Serif&quot;, Arial, sans-serif; font-size: 15px;"><span style="line-height: 2;"><span style="font-size: 22px;"><span style="color: rgb(255, 0, 0);"><span style="font-weight: 700;"><span data-mention="CHÍNH CHỦ CẦN BÁN DÃY NHÀ TRỌ GOOGM 9 PHÒNG THUỘC TP MỸ THO -TIỀN GIANG " id="input_part_0" style="white-space: pre-wrap;">CHÍNH CHỦ CẦN BÁN DÃY NHÀ TRỌ GOOGM 9 PHÒNG THUỘC TP MỸ THO -TIỀN GIANG </span></span></span></span></span></div><div id="input_line_1" style="color: rgb(0, 26, 51); font-family: &quot;Segoe UI&quot;, SegoeuiPc, &quot;San Francisco&quot;, &quot;Helvetica Neue&quot;, Helvetica, &quot;Lucida Grande&quot;, Roboto, Ubuntu, Tahoma, &quot;Microsoft Sans Serif&quot;, Arial, sans-serif; font-size: 15px;">&nbsp;</div><div id="input_line_2" style="color: rgb(0, 26, 51); font-family: &quot;Segoe UI&quot;, SegoeuiPc, &quot;San Francisco&quot;, &quot;Helvetica Neue&quot;, Helvetica, &quot;Lucida Grande&quot;, Roboto, Ubuntu, Tahoma, &quot;Microsoft Sans Serif&quot;, Arial, sans-serif; font-size: 15px;"><span style="font-size: 20px;"><span data-mention="-Diện tích : 223,5 m2 " id="input_part_0" style="white-space: pre-wrap;">-Diện tích : 223,5 m2 </span></span></div><div id="input_line_3" style="color: rgb(0, 26, 51); font-family: &quot;Segoe UI&quot;, SegoeuiPc, &quot;San Francisco&quot;, &quot;Helvetica Neue&quot;, Helvetica, &quot;Lucida Grande&quot;, Roboto, Ubuntu, Tahoma, &quot;Microsoft Sans Serif&quot;, Arial, sans-serif; font-size: 15px;">&nbsp;</div><div id="input_line_4" style="color: rgb(0, 26, 51); font-family: &quot;Segoe UI&quot;, SegoeuiPc, &quot;San Francisco&quot;, &quot;Helvetica Neue&quot;, Helvetica, &quot;Lucida Grande&quot;, Roboto, Ubuntu, Tahoma, &quot;Microsoft Sans Serif&quot;, Arial, sans-serif; font-size: 15px;"><span style="font-size: 20px;"><span data-mention="- Địa chỉ : Khu Phố 10 -Phường 5 - TP Mỹ Tho -Tỉnh Tiền Giang " id="input_part_0" style="white-space: pre-wrap;">- Địa chỉ : Khu Phố 10 -Phường 5 - TP Mỹ Tho -Tỉnh Tiền Giang </span></span></div><div id="input_line_5" style="color: rgb(0, 26, 51); font-family: &quot;Segoe UI&quot;, SegoeuiPc, &quot;San Francisco&quot;, &quot;Helvetica Neue&quot;, Helvetica, &quot;Lucida Grande&quot;, Roboto, Ubuntu, Tahoma, &quot;Microsoft Sans Serif&quot;, Arial, sans-serif; font-size: 15px;">&nbsp;</div><div id="input_line_6" style="color: rgb(0, 26, 51); font-family: &quot;Segoe UI&quot;, SegoeuiPc, &quot;San Francisco&quot;, &quot;Helvetica Neue&quot;, Helvetica, &quot;Lucida Grande&quot;, Roboto, Ubuntu, Tahoma, &quot;Microsoft Sans Serif&quot;, Arial, sans-serif; font-size: 15px;"><span style="font-size: 20px;"><span data-mention="- Chính chủ pháp lí đầy đủ ,sổ đỏ riêng " id="input_part_0" style="white-space: pre-wrap;">- Chính chủ pháp lí đầy đủ ,sổ đỏ riêng </span></span></div><div id="input_line_7" style="color: rgb(0, 26, 51); font-family: &quot;Segoe UI&quot;, SegoeuiPc, &quot;San Francisco&quot;, &quot;Helvetica Neue&quot;, Helvetica, &quot;Lucida Grande&quot;, Roboto, Ubuntu, Tahoma, &quot;Microsoft Sans Serif&quot;, Arial, sans-serif; font-size: 15px;">&nbsp;</div><div id="input_line_8" style="color: rgb(0, 26, 51); font-family: &quot;Segoe UI&quot;, SegoeuiPc, &quot;San Francisco&quot;, &quot;Helvetica Neue&quot;, Helvetica, &quot;Lucida Grande&quot;, Roboto, Ubuntu, Tahoma, &quot;Microsoft Sans Serif&quot;, Arial, sans-serif; font-size: 15px;"><span style="font-size: 20px;"><span data-mention="- Dãy nhà trọ 9 phòng ,Do k có người trông coi  Nay muốn sang gấp" id="input_part_0" style="white-space: pre-wrap;">- Dãy nhà trọ 9 phòng ,Do k có người trông coi Nay muốn sang gấp</span></span></div><div id="input_line_9" style="color: rgb(0, 26, 51); font-family: &quot;Segoe UI&quot;, SegoeuiPc, &quot;San Francisco&quot;, &quot;Helvetica Neue&quot;, Helvetica, &quot;Lucida Grande&quot;, Roboto, Ubuntu, Tahoma, &quot;Microsoft Sans Serif&quot;, Arial, sans-serif; font-size: 15px;">&nbsp;</div><div id="input_line_10" style="color: rgb(0, 26, 51); font-family: &quot;Segoe UI&quot;, SegoeuiPc, &quot;San Francisco&quot;, &quot;Helvetica Neue&quot;, Helvetica, &quot;Lucida Grande&quot;, Roboto, Ubuntu, Tahoma, &quot;Microsoft Sans Serif&quot;, Arial, sans-serif; font-size: 15px;"><span style="font-size: 20px;"><span data-mention="- Giao thông thuận tiện đi lại ,khu vực dân cư đông đúc ,an ninh tốt " id="input_part_0" style="white-space: pre-wrap;">- Giao thông thuận tiện đi lại ,khu vực dân cư đông đúc ,an ninh tốt </span></span></div><div id="input_line_11" style="color: rgb(0, 26, 51); font-family: &quot;Segoe UI&quot;, SegoeuiPc, &quot;San Francisco&quot;, &quot;Helvetica Neue&quot;, Helvetica, &quot;Lucida Grande&quot;, Roboto, Ubuntu, Tahoma, &quot;Microsoft Sans Serif&quot;, Arial, sans-serif; font-size: 15px;">&nbsp;</div><div id="input_line_12" style="color: rgb(0, 26, 51); font-family: &quot;Segoe UI&quot;, SegoeuiPc, &quot;San Francisco&quot;, &quot;Helvetica Neue&quot;, Helvetica, &quot;Lucida Grande&quot;, Roboto, Ubuntu, Tahoma, &quot;Microsoft Sans Serif&quot;, Arial, sans-serif; font-size: 15px;"><span style="font-size: 20px;"><span data-mention="-Giá 2tỉ3  ( Tới xem đất thương lượng  ) " id="input_part_0" style="white-space: pre-wrap;">-Giá 2tỉ3 ( Tới xem đất thương lượng ) </span></span></div><div id="input_line_13" style="color: rgb(0, 26, 51); font-family: &quot;Segoe UI&quot;, SegoeuiPc, &quot;San Francisco&quot;, &quot;Helvetica Neue&quot;, Helvetica, &quot;Lucida Grande&quot;, Roboto, Ubuntu, Tahoma, &quot;Microsoft Sans Serif&quot;, Arial, sans-serif; font-size: 15px;">&nbsp;</div><div id="input_line_14" style="color: rgb(0, 26, 51); font-family: &quot;Segoe UI&quot;, SegoeuiPc, &quot;San Francisco&quot;, &quot;Helvetica Neue&quot;, Helvetica, &quot;Lucida Grande&quot;, Roboto, Ubuntu, Tahoma, &quot;Microsoft Sans Serif&quot;, Arial, sans-serif; font-size: 15px;"><span style="color: rgb(255, 0, 0);"><span style="font-size: 20px;"><span data-mention="-Liên hệ sdt : Hoà  0973237010" id="input_part_0" style="white-space: pre-wrap;">-Liên hệ sdt : Hoà 0973237010</span></span></span></div>', 1, CAST(N'2021-09-06T19:09:04.013' AS DateTime), CAST(N'2022-05-31T23:54:24.810' AS DateTime), N'bai-viet-1', 11, 1)
INSERT [dbo].[News] ([Id], [Name], [CategoryId], [Logo], [Description], [Detail], [IsNew], [CreateDate], [EditDate], [Url], [DisplayOrder], [Status]) VALUES (3, N'hhhh', 1, N'/uploads/406e9735-a741-4921-93bb-cbfcfde0408c.png', N'ddd', N'<p>dd</p>', 1, CAST(N'2021-09-06T20:14:44.463' AS DateTime), CAST(N'2021-09-06T20:46:33.327' AS DateTime), N'hhhh', 1, 1)
SET IDENTITY_INSERT [dbo].[News] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Id], [Name], [CategoryId], [Logo], [Description], [Detail], [Price], [PriceDiscount], [IsNew], [CreateDate], [EditDate], [Url], [DisplayOrder], [Status]) VALUES (1, N'Cá Lăng Sông Đà Đang Bơi', 34, N'/uploads/1396113f-a068-4ef8-a135-841a8be32f2c.png', N'Do d?c tính s?n ph?m nên tr?ng lu?ng th?c t? có th? chênh l?ch so v?i s? lu?ng b?n d?t hàng. Siêu th? h?i s?n Bi?n Ðông s? xác nh?n v?i b?n khi có s? thay d?i', N'<p>Do d?c tính s?n ph?m nên tr?ng lu?ng th?c t? có th? chênh l?ch so v?i s? lu?ng b?n d?t hàng. Siêu th? h?i s?n Bi?n Ðông s? xác nh?n v?i b?n khi có s? thay d?i</p>', CAST(247500 AS Decimal(18, 0)), CAST(222500 AS Decimal(18, 0)), 1, CAST(N'2022-05-31T08:59:56.453' AS DateTime), CAST(N'2022-05-31T09:04:15.503' AS DateTime), N'wwwwwww', NULL, 1)
INSERT [dbo].[Products] ([Id], [Name], [CategoryId], [Logo], [Description], [Detail], [Price], [PriceDiscount], [IsNew], [CreateDate], [EditDate], [Url], [DisplayOrder], [Status]) VALUES (2, N'Cua thịt Cà Mau (2 con/kg)', 38, N'/uploads/0f9cca1c-6ba5-4f0a-83c8-1427b1e4a6f8.png', N'Do d?c tính s?n ph?m nên tr?ng lu?ng th?c t? có th? chênh l?ch so v?i s? lu?ng b?n d?t hàng. Siêu th? h?i s?n Bi?n Ðông s? xác nh?n v?i b?n khi có s? thay d?', N'<p style="margin-right: 0px; margin-left: 0px; padding: 0px; color: rgb(51, 51, 51); font-family: Nunito, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px;"><span style="margin: 0px; padding: 0px; font-weight: bolder;">Xu?t x?:&nbsp;</span>Nam Can, Cà Mau</p><p style="margin-right: 0px; margin-left: 0px; padding: 0px; color: rgb(51, 51, 51); font-family: Nunito, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px;"><span style="margin: 0px; padding: 0px; font-weight: bolder;">Size:&nbsp;</span>2 con/kg</p><p style="margin-right: 0px; margin-left: 0px; padding: 0px; color: rgb(51, 51, 51); font-family: Nunito, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px;">Dây bu?c là lo?i&nbsp;dây ni lông m?ng</p><p style="margin-right: 0px; margin-left: 0px; padding: 0px; color: rgb(51, 51, 51); font-family: Nunito, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px;"><span style="margin: 0px; padding: 0px; font-weight: bolder;">Cam k?t:</span>&nbsp;Bao óp 1 d?i 1&nbsp;</p><p style="margin-right: 0px; margin-left: 0px; padding: 0px; color: rgb(51, 51, 51); font-family: Nunito, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px;"><span style="margin: 0px; padding: 0px; font-weight: bolder;">Món ngon:&nbsp;</span>s?t tr?ng mu?i, s?t ?t Singapore, s?t me, l?u, h?p...</p>', CAST(300000 AS Decimal(18, 0)), CAST(289000 AS Decimal(18, 0)), 1, CAST(N'2022-05-31T09:05:41.537' AS DateTime), NULL, N'cua-thit-ca-mau-2-conkg', NULL, 1)
INSERT [dbo].[Products] ([Id], [Name], [CategoryId], [Logo], [Description], [Detail], [Price], [PriceDiscount], [IsNew], [CreateDate], [EditDate], [Url], [DisplayOrder], [Status]) VALUES (3, N'Ốc Hương to (90-110 con/kg)', 37, N'/uploads/a4bd49fc-d03a-4e16-863c-7c3ce4f09374.png', N'Do d?c tính s?n ph?m nên tr?ng lu?ng th?c t? có th? chênh l?ch so v?i s? lu?ng b?n d?t hàng. Siêu th? h?i s?n Bi?n Ðông s? xác nh?n v?i b?n khi có s? thay d?i', N'<p style="margin-right: 0px; margin-left: 0px; padding: 0px; color: rgb(51, 51, 51); font-family: Nunito, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px;">?c Huong làm món h?p lá chanh, nu?ng, s?t tr?ng mu?i, cháy t?i ...&nbsp;<br style="margin: 0px; padding: 0px;">Chúng tôi d?m b?o hàng s?ng dang boi, ch?t lu?ng hàng lo?i 1</p><p style="margin-right: 0px; margin-left: 0px; padding: 0px; color: rgb(51, 51, 51); font-family: Nunito, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px;">Ð?A CH? H?I S?N BIE^?N ÐÔNG:</p><p style="margin-right: 0px; margin-left: 0px; padding: 0px; color: rgb(51, 51, 51); font-family: Nunito, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px;">(Gi? m? c?a 07h d?n 23h)</p><p style="margin-right: 0px; margin-left: 0px; padding: 0px; color: rgb(51, 51, 51); font-family: Nunito, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px;"><img alt="??" referrerpolicy="origin-when-cross-origin" src="https://static.xx.fbcdn.net/images/emoji.php/v9/t9/1.5/16/1f3af.png" style="margin: 0px; padding: 0px; border-width: initial; border-color: initial; border-image: initial; max-width: 100%; height: 16px; width: 16px;">&nbsp;Co? so?? 1: So^´ 2, ngõ 84, Tra^`n Thái Tông, Ca^`u Gia^´y, Hà N?i. 0902147886 - 0936253588 (có Zalo)</p><p style="margin-right: 0px; margin-left: 0px; padding: 0px; color: rgb(51, 51, 51); font-family: Nunito, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px;"><img alt="??" referrerpolicy="origin-when-cross-origin" src="https://static.xx.fbcdn.net/images/emoji.php/v9/t9/1.5/16/1f3af.png" style="margin: 0px; padding: 0px; border-width: initial; border-color: initial; border-image: initial; max-width: 100%; height: 16px; width: 16px;">&nbsp;Co s? 3: S? 794 Ðu?ng Láng, Ð?ng Ða, Hà N?i, 0898080794 (có Zalo)</p><p style="margin-right: 0px; margin-left: 0px; padding: 0px; color: rgb(51, 51, 51); font-family: Nunito, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px;"><img alt="??" referrerpolicy="origin-when-cross-origin" src="https://static.xx.fbcdn.net/images/emoji.php/v9/t9/1.5/16/1f3af.png" style="margin: 0px; padding: 0px; border-width: initial; border-color: initial; border-image: initial; max-width: 100%; height: 16px; width: 16px;">&nbsp;Co? so?? 6: Bie?^t thu?? Phong Lan 01-01, KÐT Vinhomes Riverside, Long Biên, Hà N?i (ma??t du?o?`ng Nguye^~n Lam - ca?nh co^?ng an ninh 34). 0906263616, 0363283898 (có Zalo)</p><p style="margin-right: 0px; margin-left: 0px; padding: 0px; color: rgb(51, 51, 51); font-family: Nunito, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px;"><img alt="??" referrerpolicy="origin-when-cross-origin" src="https://static.xx.fbcdn.net/images/emoji.php/v9/t9/1.5/16/1f3af.png" style="margin: 0px; padding: 0px; border-width: initial; border-color: initial; border-image: initial; max-width: 100%; height: 16px; width: 16px;">&nbsp;Co? so?? 9: S? 67 Ngô Thì Nh?m, Hai Bà Trung, Hà N?i (dúng góc ngã 3 Hoà Mã - Ngô Thì Nh?m) - 0971666508, 0931269289 (có Zalo)</p>', CAST(349000 AS Decimal(18, 0)), CAST(300000 AS Decimal(18, 0)), 1, CAST(N'2022-05-31T09:06:48.343' AS DateTime), NULL, N'oc-huong-to-90-110-conkg', NULL, 1)
INSERT [dbo].[Products] ([Id], [Name], [CategoryId], [Logo], [Description], [Detail], [Price], [PriceDiscount], [IsNew], [CreateDate], [EditDate], [Url], [DisplayOrder], [Status]) VALUES (4, N'Ngao Giấy (10 - 15 con/kg)', 37, N'/uploads/c0dcfaba-49a8-4846-80b1-5cb01de555a4.png', N'Ngao Gi?y H?p C?i (10 - 15 con/kg)', N'<p><span style="color: rgb(51, 51, 51); font-family: Nunito, &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px;">Ngao Gi?y H?p C?i (10 - 15 con/kg)</span><br></p>', CAST(60000 AS Decimal(18, 0)), NULL, 1, CAST(N'2022-05-31T09:08:37.483' AS DateTime), NULL, N'ngao-giay-10-15-conkg', NULL, 1)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[Promotion] ON 

INSERT [dbo].[Promotion] ([Id], [Name], [Logo], [Link], [Status], [DisplayOrder], [CreateDate]) VALUES (1, N'aaa', N'/uploads/2ab00fc6-6346-468f-9a3c-5b239fdbe89d.png', N'aa', 1, 1, CAST(N'2021-09-07T20:29:05.747' AS DateTime))
INSERT [dbo].[Promotion] ([Id], [Name], [Logo], [Link], [Status], [DisplayOrder], [CreateDate]) VALUES (2, N'qqq', N'/uploads/14275e77-cb2e-4ed7-acea-3e9540de96da.png', N'qqq', 1, 11, CAST(N'2021-09-07T20:29:42.177' AS DateTime))
SET IDENTITY_INSERT [dbo].[Promotion] OFF
GO
SET IDENTITY_INSERT [dbo].[Slides] ON 

INSERT [dbo].[Slides] ([Id], [Name], [Logo], [Link], [Status], [DisplayOrder], [CreateDate]) VALUES (1, N'slide 2', N'/uploads/f3fc86d0-76ce-414b-b98c-a79fee349dd9.png', N'kkkkk', 1, 1, CAST(N'2021-09-07T16:31:05.600' AS DateTime))
INSERT [dbo].[Slides] ([Id], [Name], [Logo], [Link], [Status], [DisplayOrder], [CreateDate]) VALUES (2, N'slide 2', N'/uploads/52abcc31-968b-4ad3-9722-41cab6e386ce.png', N'kkkkk', 1, 2, CAST(N'2021-09-07T16:33:44.903' AS DateTime))
SET IDENTITY_INSERT [dbo].[Slides] OFF
GO
SET IDENTITY_INSERT [dbo].[TopMenu] ON 

INSERT [dbo].[TopMenu] ([Id], [Name], [Logo], [Link], [Status], [DisplayOrder], [CreateDate]) VALUES (1, N'dddđ', N'/uploads/2d179ecf-981b-45d3-ad25-53431fa4b81e.png', N'ddđ', 1, 1, CAST(N'2021-09-07T20:22:35.440' AS DateTime))
INSERT [dbo].[TopMenu] ([Id], [Name], [Logo], [Link], [Status], [DisplayOrder], [CreateDate]) VALUES (2, N'ss', N'/uploads/09ab4e00-3e4f-4d50-a203-b55c0e55ce19.png', N'1111', 1, 111, CAST(N'2021-09-07T20:30:49.150' AS DateTime))
SET IDENTITY_INSERT [dbo].[TopMenu] OFF
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[News]  WITH CHECK ADD  CONSTRAINT [FK_News_CategoriesNew] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[CategoriesNew] ([Id])
GO
ALTER TABLE [dbo].[News] CHECK CONSTRAINT [FK_News_CategoriesNew]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Order] FOREIGN KEY([OrderId])
REFERENCES [dbo].[Order] ([Id])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Order]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD  CONSTRAINT [FK_OrderDetail_Products] FOREIGN KEY([ProductId])
REFERENCES [dbo].[Products] ([Id])
GO
ALTER TABLE [dbo].[OrderDetail] CHECK CONSTRAINT [FK_OrderDetail_Products]
GO
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Category]
GO
