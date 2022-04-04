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


use Tournaments
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE dbo.spMatchupEntries_GetByMatchup
	@MatchupId int
AS
BEGIN
	SET NOCOUNT ON;
	select *
	from MatchupEntries
	where MatchupId = @MatchupId
END
GO

use Tournaments
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
DROP PROCEDURE dbo.spTestPerson_GetByLastName
GO
CREATE PROCEDURE dbo.spTestPerson_GetByLastName
	@LastName nvarchar(100)
AS
BEGIN

	SET NOCOUNT ON;
	select *
	from dbo.People
	where LASTName = @LastName
END
GO



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


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

drop PROCEDURE spTeams_Insert
go

CREATE PROCEDURE spTeams_Insert
@TeamName nvarchar(100),
@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

insert into dbo.Teams (TeamName)
values (@TeamName);

select @id = SCOPE_IDENTITY();
END
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop PROCEDURE dbo.spTeamMembers_Insert
go
CREATE PROCEDURE dbo.spTeamMembers_Insert
	-- Add the parameters for the stored procedure here
	@TeamId int,
	@PersonId int,
	@id int = 0 output
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    insert into dbo.TeamMembers(TeamId, PersonId)
	values (@TeamId, @PersonId)
	select @id = SCOPE_IDENTITY();
	
END
GO


SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop procedure dbo.spTeamMembers_GetByTeam
go

CREATE PROCEDURE dbo.spTeamMembers_GetByTeam
	@TeamId int
AS
BEGIN
	
	SET NOCOUNT ON;

	select p.*
	from dbo.TeamMembers m
	inner join dbo.People p on m.PersonId = p.id
	where m.TeamId = @TeamId
END
GO


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

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

drop procedure dbo.spPeople_Insert
go

CREATE PROCEDURE dbo.spPeople_Insert
	@FirstName nvarchar(100),
	@LastName nvarchar(100),
	@EmailAddress nvarchar(100),
	@CellphoneNumber varchar(20),
	@id int = 0 output
AS
BEGIN

	SET NOCOUNT ON;
	insert into dbo.People(FirstName,LastName,EmailAddress,cellphoneNumber)
	values(@FirstName,@LastName,@EmailAddress,@CellphoneNumber);

	select @id=SCOPE_IDENTITY();
END
GO


use Tournaments
go
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop procedure spMatchupEntries_Update
go
CREATE PROCEDURE spMatchupEntries_Update
@id int,
@TeamCompetingId int = null,
@Score float = null

AS
BEGIN
	
	SET NOCOUNT ON;

    update dbo.MatchupEntries
	set TeamCompetingId = @TeamCompetingId, Score  = @Score
	where id = @id
END
GO


USE [Tournaments]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop PROCEDURE dbo.spMatchupEntries_Insert
GO
CREATE PROCEDURE dbo.spMatchupEntries_Insert
	@MatchupId int,
	@ParentMatchupId int,
	@TeamCompetingId int,
	@id int = 0 output
AS
BEGIN

	SET NOCOUNT ON;

	insert into dbo.MatchupEntries( MatchupId, ParentMatchupId, TeamCompetingId)
	values(@MatchupId, @ParentMatchupId, @TeamCompetingId)

	select @id = SCOPE_IDENTITY()
END
GO
