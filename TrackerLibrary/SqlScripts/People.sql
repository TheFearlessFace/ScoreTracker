USE [Tournaments]
GO
alter table [dbo].[TeamMembers]
drop constraint FK_TeamMembers_People

/****** Object:  Table [dbo].[Prices]    Script Date: 2019/09/26 15:18:43 ******/
DROP TABLE [dbo].[People]
GO

/****** Object:  Table [dbo].[Prices]    Script Date: 2019/09/26 15:18:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[People](
[id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](100) NOT NULL,
	[LastName] [nvarchar](100) NOT NULL,
	[EmailAddress] [nvarchar](200) NOT NULL,
	[CellPhoneNumber] [varchar](20) NULL,
	[NumberOfKids] [int] NULL,
	[CreatDate] [datetime2] NULL
 CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED 
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