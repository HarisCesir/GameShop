SET QUOTED_IDENTIFIER ON
GO
SET ANSI_NULLS ON
GO
CREATE PROCEDURE [dbo].[SELECTNARUDZBABYKUPAC]
(
@KupacID int

)

AS

SELECT T1.NarudzbaID, T1.BrojNarudzbe,T1.Datum,T1.Racun,T4.Naziv,T2.Kolicina,T4.Cijena FROM Narudzbe AS T1 inner join NarudzbeStavke AS T2 on T1.NarudzbaID=T2.NarudzbaID inner join Kupci AS T3 on T1.KupacID=T3.KupacID inner join Igre AS T4 on T2.IgraID=T4.IgraID
WHERE T3.KupacID=@KupacID
ORDER BY T3.KupacID

GO
