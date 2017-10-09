CREATE TABLE [dbo].[Depots]
(
	[IdDepot] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Designation] VARCHAR(50) NULL, 
    [Qte_Stocke] FLOAT NULL, 
    [Qte_Limite] FLOAT NULL, 
    [Localisation] VARCHAR(50) NULL
)
