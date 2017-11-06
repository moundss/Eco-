CREATE TABLE [dbo].[Distribuer]
(
	[IdDistribuer] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Qte_distribuer] FLOAT NULL, 
    [Date_distribuer] DATETIME NULL, 
    [Id_exploitant] INT NULL, 
    [id_depot] INT NULL
)
