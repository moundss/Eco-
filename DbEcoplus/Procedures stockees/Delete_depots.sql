CREATE PROCEDURE [dbo].[Delete_depots]
	@idDepots varchar(50)
AS

DELETE FROM [dbo].[Depots]
      WHERE IdDepot=@idDepots
GO

