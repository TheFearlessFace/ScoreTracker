use Tournaments
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop PROCEDURE dbo.spPrizes_GetByTournament
go
CREATE PROCEDURE dbo.spPrizes_GetByTournament
@TournamentId int
AS
BEGIN
	
	SET NOCOUNT ON;

    select p.*
	from Prizes p
	inner join dbo.TournamentPrizes t on p.id = t.PrizeId
	where t.TournamentId = @TournamentId
END
GO
