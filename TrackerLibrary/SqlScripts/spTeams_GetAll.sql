SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

drop procedure dbo.spTeams_GetAll
go

CREATE PROCEDURE dbo.spTeams_GetAll
	
AS
BEGIN
	SELECT id,TeamName from dbo.Teams
END
GO

