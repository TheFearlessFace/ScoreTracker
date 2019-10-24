USE [Tournaments]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP PROCEDURE dbo.spMatchupEntries_Insert
GO
CREATE PROCEDURE dbo.spMatchupEntries_Insert
	@MatchupId int,
	@ParentMatchupId int,
	@TeamCompetingId int,
	@id int = 0 output
AS
BEGIN

	SET NOCOUNT ON;

	insert into dbo.MatchupEntries( MatchupId, ParentMatchupId, TeamCompetingId)
	values(@MatchupId, @ParentMatchupId, @TeamCompetingId)

	select @id = SCOPE_IDENTITY()
END
GO
