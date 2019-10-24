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
