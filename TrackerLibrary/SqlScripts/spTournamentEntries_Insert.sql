use Tournaments
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

drop procedure dbo.spTournamentEntries_Insert
go

CREATE PROCEDURE dbo.spTournamentEntries_Insert
	@TournamentId int,
	@TeamId int,
	@id int = 0 output
	
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.TournamentEntries (TournamentId,TeamId)
	values (@TournamentId,@TeamId)

	select @id = SCOPE_IDENTITY();
END
GO
