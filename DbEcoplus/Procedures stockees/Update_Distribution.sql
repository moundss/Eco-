CREATE PROCEDURE [dbo].[Update_Distribution]
	@Id_dist varchar(50),
	@qte_distribuer float,
	@dateDistribuer date,
	@id_exploitant varchar(50),
	@id_depot varchar(50)
AS

UPDATE [dbo].[Distribuer]
   SET [Qte_distribuer] = @qte_distribuer
      ,[Date_distribuer] = @dateDistribuer
      ,[Id_exploitant] = @id_exploitant
      ,[id_depot] = @id_depot
 WHERE [IdDistribuer] = @Id_dist
      
GO


