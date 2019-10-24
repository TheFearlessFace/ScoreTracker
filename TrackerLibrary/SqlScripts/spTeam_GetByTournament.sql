use Tournaments
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

drop procedure  dbo.spTeam_GetByTournament
go

CREATE PROCEDURE dbo.spTeam_GetByTournament
@TournamentId int
AS
BEGIN
SET NOCOUNT on;


	select t.*
	from dbo.Teams t
	inner join dbo.TournamentEntries e on t.id = e.TeamId
	inner join dbo.Tournaments tm on e.TournamentId = tm.id
	where tm.id = @TournamentId
END
GO
