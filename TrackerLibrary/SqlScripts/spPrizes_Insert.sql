use Tournaments
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE dbo.spPrizes_Insert
	@PlaceNumber int,
	@PlaceName nvarchar(50),
	@PrizeAmount money,
	@PrizePercentage float,
	@id int = 0 output
AS
BEGIN
	SET NOCOuNT ON;

	insert into dbo.Prizes(PlaceNumber,PlaceName,PriceAmount,PrizePercentage)
	values (@PlaceNumber,@PlaceName,@PrizeAmount,@PrizePercentage);

	select @id = SCOPE_IDENTITY();

END
GO



