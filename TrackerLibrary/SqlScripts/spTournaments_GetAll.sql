use Tournaments
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop procedure dbo.spTournaments_GetAll
go
CREATE PROCEDURE dbo.spTournaments_GetAll
	--@TournamentName nvarchar(100),
	--@EntryFee money,
	--@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	select *
	from dbo.Tournaments
	where Active = 1
END
GO