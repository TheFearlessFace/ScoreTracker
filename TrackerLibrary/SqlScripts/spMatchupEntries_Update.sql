use Tournaments
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop procedure spMatchupEntries_Update
go
CREATE PROCEDURE spMatchupEntries_Update
@id int,
@TeamCompetingId int = null,
@Score float = null

AS
BEGIN
	
	SET NOCOUNT ON;

    update dbo.MatchupEntries
	set TeamCompetingId = @TeamCompetingId, Score  = @Score
	where id = @id
END
GO
