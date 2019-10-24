USE [Tournaments]
GO

alter table [dbo].[TeamMembers]
drop constraint FK_TeamMembers_People

alter table [dbo].[TeamMembers]
drop constraint FK_TeamMembers_Teams

/****** Object:  Table [dbo].[TeamMembers]    Script Date: 2019/09/27 08:24:38 ******/
DROP TABLE [dbo].[TeamMembers]
GO

/****** Object:  Table [dbo].[TeamMembers]    Script Date: 2019/09/27 08:24:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TeamMembers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TeamId] [int] NOT NULL,
	[PersonId] [int] NOT Null
 CONSTRAINT [PK_TeamMembers] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


ALTER TABLE dbo.TeamMembers ADD CONSTRAINT
	FK_TeamMembers_People FOREIGN KEY
	(
	PersonId
	) REFERENCES dbo.People
	(
	id
	) ON UPDATE  CASCADE
	 ON DELETE  CASCADE 
	
GO

ALTER TABLE dbo.TeamMembers ADD CONSTRAINT
	FK_TeamMembers_Teams FOREIGN KEY
	(
	TeamId
	) REFERENCES dbo.Teams
	(
	id
	) ON UPDATE  CASCADE
	 ON DELETE  CASCADE
	
GO