CREATE PROCEDURE [dbo].[Delete_depots]
	@idDepots int
AS

delete from Depots where IdDepot=@idDepots
GO

