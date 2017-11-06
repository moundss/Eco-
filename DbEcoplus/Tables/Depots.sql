CREATE TABLE [dbo].[Depots]
(
	[IdDepot] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [Designation] VARCHAR(50) NULL, 
    [Qte_Stocke] FLOAT NULL, 
    [Qte_Limite] FLOAT NULL, 
    [Localisation] VARCHAR(50) NULL, 
    [Semence] VARCHAR(50) NULL
)
