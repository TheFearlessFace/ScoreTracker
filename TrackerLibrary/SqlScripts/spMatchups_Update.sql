use Tournaments
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop PROCEDURE dbo.spMatchups_Update
go
CREATE PROCEDURE dbo.spMatchups_Update
	@id int,
	@WinnerId int
AS
BEGIN
	
	SET NOCOUNT ON;
	update dbo.Matchups
	set WinnerId =@WinnerId
	where id = @id
END
GO
