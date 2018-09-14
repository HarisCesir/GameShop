SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SELECTRECENZIJE]

AS

SELECT T1.RecenzijaID, T1.Naslov,T1.Datum,T1.Sadrzaj,T2.Ime+''+T2.Prezime AS ImePrezime FROM Recenzije AS T1 inner join Korisnici AS T2 ON T1.KorisnikID=T2.KorisnikID
ORDER BY T1.KorisnikID

GO
