CREATE PROCEDURE [dbo].[Insert_depots]
	
	@libelle varchar(50),
	@Qte_stocke float,
	@Qte_limite float,
	@localisation varchar(50),
	@semence varchar(50)
AS

INSERT INTO [dbo].[Depots]
           (
            [Designation]
           ,[Qte_Stocke]
           ,[Qte_Limite]
           ,[Localisation]
		   ,[Semence])
     VALUES
           (@libelle,@Qte_stocke,@Qte_limite,@localisation,@semence)
GO

