CREATE PROCEDURE [dbo].[Delete_Distribution]
	@idDistribuer int
AS

DELETE FROM [dbo].[Distribuer]
      WHERE IdDistribuer=@idDistribuer
GO

