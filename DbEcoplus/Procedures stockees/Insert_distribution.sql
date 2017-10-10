CREATE PROCEDURE [dbo].[Insert_distribution]
	@Id_dist varchar(50),
	@qte_distribuer float,
	@dateDistribuer date,
	@id_exploitant varchar(50),
	@id_depot varchar(50)
AS

INSERT INTO [dbo].[Distribuer]
           ([IdDistribuer]
           ,[Qte_distribuer]
           ,[Date_distribuer]
           ,[Id_exploitant]
           ,[id_depot])
     VALUES
           (@Id_dist,@qte_distribuer,@dateDistribuer,@id_exploitant,@id_depot)
GO


