use Tournaments
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE dbo.spMatchupEntries_GetByMatchup
	@MatchupId int
AS
BEGIN
	SET NOCOUNT ON;
	select *
	from MatchupEntries
	where MatchupId = 1@MatchupId
END
GO
