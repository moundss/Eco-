CREATE PROCEDURE [dbo].[SimplExplt]
	
AS
	SELECT IdExploitant, nom +' '+ Prenom as Designation , District,Departement,Nature
	FROM Exploitants
	

