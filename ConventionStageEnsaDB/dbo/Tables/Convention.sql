CREATE TABLE [dbo].[Convention]
(
    [Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [IdEtudiant] NVARCHAR(50) NOT NULL, 
    [NomEntreprise] NVARCHAR(50) NOT NULL, 
    [Ville] NVARCHAR(50) NOT NULL, 
    [DateDebut] DATE NOT NULL, 
    [DateFin] DATE NOT NULL, 
    [Etat] NVARCHAR(50) NOT NULL
)
