use Tournaments
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
drop procedure dbo.spPeople_GetAll
go

CREATE PROCEDURE dbo.spPeople_GetAll 
	
AS
BEGIN
	SELECT id,FirstName,LastName,EmailAddress,CellPhoneNumber from People
END
GO
