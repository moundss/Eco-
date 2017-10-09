CREATE PROCEDURE [dbo].[Insert_distribution]
	@Id_dist varchar(50),
	@qte_distribuer float,
	@id_exploitant varchar(50),
	@id_depot varchar(50)
AS
	INSERT INTO Distribuer(IdDistribuer,Qte_distribuer,Id_exploitant,id_depot) VALUES(@Id_dist,@qte_distribuer,@id_exploitant,@id_depot)
RETURN 0
