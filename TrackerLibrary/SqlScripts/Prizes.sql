USE [Tournaments]
GO

/****** Object:  Table [dbo].[Prizes]    Script Date: 2019/09/27 08:55:08 ******/
DROP TABLE [dbo].[Prizes]
GO

/****** Object:  Table [dbo].[Prizes]    Script Date: 2019/09/27 08:55:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Prizes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlaceNumber] [int] NOT NULL,
	[PlaceName] [nvarchar](50) NULL,
	[PriceAmount] [money] NULL,
	[PrizePercentage] [float] NULL,
 CONSTRAINT [PK_Prizes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


