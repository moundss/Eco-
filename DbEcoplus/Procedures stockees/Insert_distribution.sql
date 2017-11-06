CREATE PROCEDURE [dbo].[Insert_distribution]
	
	@qte_distribuer float,
	@dateDistribuer date,
	@id_exploitant int,
	@id_depot int
AS

INSERT INTO [dbo].[Distribuer]
           ([Qte_distribuer]
           ,[Date_distribuer]
           ,[Id_exploitant]
           ,[id_depot])
     VALUES
           (@qte_distribuer,@dateDistribuer,@id_exploitant,@id_depot)
GO


