CREATE PROCEDURE [dbo].[Delete_Distribution]
	@idDistribuer varchar(50)
AS

DELETE FROM [dbo].[Distribuer]
      WHERE IdDistribuer=@idDistribuer
GO

