USE [Tournaments]
GO

ALTER TABLE [dbo].[TournamentPrizes]
DROP CONSTRAINT FK_TournamentPrizes_Tournaments 

/****** Object:  Table [dbo].[Tournaments]    Script Date: 2019/09/27 07:19:36 ******/
DROP TABLE [dbo].[Tournaments]
GO

/****** Object:  Table [dbo].[Tournaments]    Script Date: 2019/09/27 07:19:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tournaments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentName] [nvarchar](100) NOT NULL,
	[EntryFee] [money] NOT NULL,
	Active bit NOT NULL
 CONSTRAINT [PK_Tournaments] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[TournamentPrizes]
   ADD CONSTRAINT FK_TournamentPrizes_Tournaments FOREIGN KEY (TournamentId)
      REFERENCES  dbo.Tournaments (Id)
      ON DELETE CASCADE
      ON UPDATE CASCADE
Go
