
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE dbo.spTournamentPrizes_Insert
@TournementId int,
@PrizeId int,
@id int =0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
	insert into dbo.TournamentPrizes( TournamentId, PrizeId)
	values( @TournementId, @PrizeId)
	select @id  = SCOPE_IDENTITY();
END
GO
