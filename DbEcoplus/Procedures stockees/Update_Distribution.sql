CREATE PROCEDURE [dbo].[Update_Distribution]
	@Id_dist int,
	@qte_distribuer float,
	@dateDistribuer date,
	@id_exploitant int,
	@id_depot int
AS

UPDATE [dbo].[Distribuer]
   SET [Qte_distribuer] = @qte_distribuer
      ,[Date_distribuer] = @dateDistribuer
      ,[Id_exploitant] = @id_exploitant
      ,[id_depot] = @id_depot
 WHERE [IdDistribuer] = @Id_dist
      
GO


