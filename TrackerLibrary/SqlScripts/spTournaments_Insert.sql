
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP PROCEDURE dbo.spTournaments_Insert
go
CREATE PROCEDURE dbo.spTournaments_Insert
	@TournamentName nvarchar(100),
	@EntryFee money,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	Insert into dbo.Tournaments ( TournamentName, EntryFee, Active)
	values ( @TournamentName, @EntryFee, 1);

	select @id  = SCOPE_IDENTITY();
END
GO
