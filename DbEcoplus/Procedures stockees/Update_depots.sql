CREATE PROCEDURE [dbo].[Update_depots]
	@id varchar(50),
	@libelle varchar(50),
	@Qte_stocke float,
	@Qte_limite float,
	@localisation varchar(50)
AS


UPDATE [dbo].[Depots]
   SET 
       [Designation] = @libelle
      ,[Qte_Stocke] = @Qte_stocke
      ,[Qte_Limite] = @Qte_limite
      ,[Localisation] = @localisation
 WHERE [IdDepot] = @id
GO

