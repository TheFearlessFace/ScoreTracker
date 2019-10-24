USE [Tournaments]
GO

alter table [dbo].[TournamentPrizes]
drop constraint FK_TournamentPrizes_Tournaments

alter table [dbo].[TournamentPrizes]
drop constraint FK_TournamentPrizes_Prizes

/****** Object:  Table [dbo].[TournamentPrizes]    Script Date: 2019/09/27 07:19:36 ******/
DROP TABLE [dbo].[TournamentPrizes]
GO

/****** Object:  Table [dbo].[TournamentPrizes]    Script Date: 2019/09/27 07:19:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TournamentPrizes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentId] [int] NOT NULL,
	[PrizeId] [int] NOT NULL
 CONSTRAINT [PK_TournamentPrizes] PRIMARY KEY CLUSTERED 
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

ALTER TABLE dbo.TournamentPrizes ADD CONSTRAINT
	FK_TournamentPrizes_Prizes FOREIGN KEY
	(
	PrizeId
	) REFERENCES dbo.Prizes
	(
	Id
	) ON UPDATE  CASCADE
	 ON DELETE  CASCADE
	
GO