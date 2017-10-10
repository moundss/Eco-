CREATE PROCEDURE [dbo].[Select_depots]
AS
SELECT [IdDepot]
      ,[Designation]
      ,[Qte_Stocke]
      ,[Qte_Limite]
      ,[Localisation]
  FROM [dbo].[Depots]
GO

