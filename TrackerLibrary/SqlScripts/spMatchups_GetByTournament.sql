use Tournaments
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop PROCEDURE dbo.spMatchups_GetByTournament
go
CREATE PROCEDURE dbo.spMatchups_GetByTournament
@TournamentId int
AS
BEGIN
	SET NOCOUNT ON;

	select m.*
	from dbo.Matchups m
	where m.TournamentId = @TournamentId 
	order by m.MatchupRound
END
GO
--, t.TeamName
--left join dbo.Teams t on m.WinnerId = t.id