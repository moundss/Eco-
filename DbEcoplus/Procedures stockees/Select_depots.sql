CREATE PROCEDURE [dbo].[Select_depots]
AS
SELECT [IdDepot]
      ,[Designation]
      ,[Qte_Stocke]
      ,[Qte_Limite]
      ,[Localisation]
	  ,[Semence]
  FROM [dbo].[Depots]
GO

