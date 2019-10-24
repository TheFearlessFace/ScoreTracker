-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
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
