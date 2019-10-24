USE [Tournaments]
GO


alter table [dbo].[TournamentEntries]
drop constraint FK_TournamentEntries_Teams


/****** Object:  Table [dbo].[TournamentEntries]    Script Date: 2019/09/27 08:15:16 ******/
DROP TABLE [dbo].[TournamentEntries]
GO

/****** Object:  Table [dbo].[TournamentEntries]    Script Date: 2019/09/27 08:15:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TournamentEntries](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TournamentId] [int] NOT NULL,
	[TeamId] [int] NOT NULL,
 CONSTRAINT [PK_TournamentEntries] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE dbo.TournamentEntries ADD CONSTRAINT
	FK_TournamentEntries_Teams FOREIGN KEY
	(
	TeamId
	) REFERENCES dbo.Teams
	(
	id
	) ON UPDATE  CASCADE
	 ON DELETE  CASCADE
	
GO

