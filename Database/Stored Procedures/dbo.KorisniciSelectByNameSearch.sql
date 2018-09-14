SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[KorisniciSelectByNameSearch]
(
 @Name NVARCHAR(100)
)
AS
    SELECT T1.KorisnikID,T1.Ime,T1.Prezime,T1.Email,T1.Status, COUNT(t2.KorisnikUlogaID) AS BrojUloga
	FROM Korisnici AS T1 inner join KorisniciUloge AS T2
	ON T1.KorisnikID=T2.KorisnikID
	WHERE LOWER(Ime+''+Prezime) like @Name+'%' OR 
	     LOWER(Prezime+''+Ime) like @Name+'%'

		 GROUP BY T1.KorisnikID,T1.Ime,T1.Prezime,T1.Email,T1.Status
		 ORDER BY T1.Ime

GO
