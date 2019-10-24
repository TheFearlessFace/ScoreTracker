USE [Tournaments]
GO
alter table [dbo].[MatchupEntries]
drop constraint FK_MatchupEntries_Teams

alter table [dbo].[MatchupEntries]
drop constraint FK_MatchupEntries_Matchups

/****** Object:  Table [dbo].[MatchupEntries]    Script Date: 2019/09/27 08:29:08 ******/
DROP TABLE [dbo].[MatchupEntries]
GO

/****** Object:  Table [dbo].[MatchupEntries]    Script Date: 2019/09/27 08:29:08 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[MatchupEntries](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MatchupId] [int] NOT NULL,
	[ParentMatchupId] [int] NULL,
	[TeamCompetingId] [int] NULL,
	[Score] [float] NULL
 CONSTRAINT [PK_MatchupEntries] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE dbo.MatchupEntries ADD CONSTRAINT
	FK_MatchupEntries_Teams FOREIGN KEY
	(
	TeamCompetingId
	) REFERENCES dbo.Teams
	(
	id
	) ON UPDATE CASCADE
	 ON DELETE  CASCADE
	
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