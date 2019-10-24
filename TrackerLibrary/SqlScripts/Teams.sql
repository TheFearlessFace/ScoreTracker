USE [Tournaments]
GO

/****** Object:  Table [dbo].[Teams]    Script Date: 2019/09/27 07:19:36 ******/
DROP TABLE [dbo].[Teams]
GO

/****** Object:  Table [dbo].[Teams]    Script Date: 2019/09/27 07:19:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Teams](
	[id] [int] identity(1,1) NOT NULL,
	[TeamName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Teams] PRIMARY KEY CLUSTERED 
(
[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
