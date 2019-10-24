USE [Tournaments]
GO


alter table [dbo].[MatchupEntries]
drop constraint FK_MatchupEntries_Matchups

alter table [dbo].[Matchups]
drop constraint FK_MatchupTournaments_Matchups

alter table [dbo].[Matchups]
drop constraint FK_Matchups_Teams


/****** Object:  Table [dbo].[Matchups]    Script Date: 2019/09/27 07:19:36 ******/
DROP TABLE [dbo].[Matchups]
GO

/****** Object:  Table [dbo].[Matchups]    Script Date: 2019/09/27 07:19:36 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Matchups](
	[id] [int] IDENTITY(1,1) NOT NULL,
	TournamentId int NOT NULL,
	[WinnerId] [int] NULL,
	[MatchupRound] [int] NULL
 CONSTRAINT [PK_Matchups] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE dbo.Matchups ADD CONSTRAINT
	FK_Matchups_Teams FOREIGN KEY
	(
	WinnerId
	) REFERENCES dbo.Teams
	(
	id
	) ON UPDATE NO ACTION
	 ON DELETE  NO ACTION
	
GO
ALTER TABLE dbo.[Matchups] ADD CONSTRAINT
	FK_MatchupTournaments_Matchups FOREIGN KEY
	(
	TournamentId
	) REFERENCES dbo.Tournaments
	(
	id
	) ON UPDATE NO ACTION
	 ON DELETE  NO ACTION
	
GO

ALTER TABLE dbo.MatchupEntries ADD CONSTRAINT
	FK_MatchupEntries_Matchups FOREIGN KEY
	(
	MatchupId
	) REFERENCES dbo.Matchups
	(
	id
	) ON UPDATE NO ACTION
	 ON DELETE  NO ACTION
	
GO

