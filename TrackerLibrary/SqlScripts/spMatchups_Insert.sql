USE [Tournaments]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

DROP PROCEDURE dbo.spMatchups_Insert
GO

CREATE PROCEDURE dbo.spMatchups_Insert
	@TournamentId int,
	@MatchupRound int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	Insert into dbo.Matchups(TournamentId, MatchupRound)
	values(@TournamentId, @MatchupRound)

	select @id = SCOPE_IDENTITY()
END
GO
