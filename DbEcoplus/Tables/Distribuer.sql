CREATE TABLE [dbo].[Distribuer]
(
	[IdDistribuer] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Qte_distribuer] FLOAT NULL, 
    [Date_distribuer] DATE NULL, 
    [Id_exploitant] VARCHAR(50) NULL, 
    [id_depot] VARCHAR(50) NULL
)
