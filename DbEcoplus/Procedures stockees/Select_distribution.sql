CREATE PROCEDURE [dbo].[Select_distribution]
	
AS

SELECT [IdDistribuer]
      ,[Qte_distribuer]
      ,[Date_distribuer]
      ,[Id_exploitant]
      ,[id_depot]
  FROM [dbo].[Distribuer]
GO

