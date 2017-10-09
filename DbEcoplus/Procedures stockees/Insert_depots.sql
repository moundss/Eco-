CREATE PROCEDURE [dbo].[Insert_depots]
	@id varchar(50),
	@libelle varchar(50),
	@Qte_stocke float,
	@Qte_limite float,
	@localisation varchar(50)
AS
	INSERT into Depots(IdDepot,Designation,Qte_Stocke,Qte_Limite,Localisation) values(@id,@libelle,@Qte_stocke,@Qte_limite,@localisation)
RETURN 0
